﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using NPOI.HSSF.UserModel;
using NPOI.HPSF;
using NPOI.POIFS.FileSystem;
using NPOI.SS.UserModel;
using Framework;
using DetailInfo;
using System.IO;
namespace DetailInfo
{
    public partial class ConvertStandard : Form
    {
        protected string ProjectId = string.Empty, ecprojectid = "", Site, Str_Area, Str_FX, Str_Discipline,ActivityName;
        public ConvertStandard()
        {
            InitializeComponent();
        }
        private DataSet getconnect(string filepath, string sheetname)
        {
            //创建一个数据链接 
            string strCon = " Provider = Microsoft.ACE.OLEDB.12.0 ; Data Source = " + filepath + ";Extended Properties=Excel 12.0";
            OleDbConnection myConn = new OleDbConnection(strCon);
            string strCom = " SELECT * FROM [" + sheetname + "$]";
            myConn.Open();
            //打开数据链接，得到一个数据集 
            OleDbDataAdapter myCommand = new OleDbDataAdapter(strCom, myConn);
            //创建一个 DataSet对象 
            DataSet myDataSet = new DataSet();
            //得到自己的DataSet对象 
            myCommand.Fill(myDataSet, "[" + sheetname + "$]");

            return myDataSet;
            //dataGridView1.DataSource = myDataSet.Tables["Sheet1$"].DefaultView;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProjectCmbItem item = (ProjectCmbItem)cmb_project.SelectedItem;
            if (item == null)
            {
                MessageBox.Show("请选择项目", "提示");
                return;
            }
            ProjectId = item.Value;
            Site = cmb_site.SelectedValue.ToString();
            openFileDialog1.Filter = "xls files|*.xlsx";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string aimfile = openFileDialog1.FileName.ToString();
                //MessageBox.Show(aimfile);
                textBox1.Text = aimfile;
                //getconnect(aimfile, "Sheet1");
                dgv1.DataMember = "[定 额 表$]";
                dgv1.DataSource = getconnect(aimfile, "定 额 表");
                dgv1.Columns[0].ReadOnly = true;
                dgv1.Columns[1].ReadOnly = true;
                dgv1.Columns[2].ReadOnly = true;
                dgv1.Columns[3].ReadOnly = true;
                dgv1.Columns[4].ReadOnly = true;
                dgv1.Columns[5].ReadOnly = true;
                dgv1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgv1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgv1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgv1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgv1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgv1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                //读取excel 文件
            }
            else
            { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgv1.RowCount < 1) return;
            #region 开始循环比对Excel中的每行的材料号是否都对。
            for (int i = 0; i < dgv1.RowCount - 1; i++)
            {

                string partno = dgv1.Rows[i].Cells[0].Value.ToString();
                if (string.IsNullOrEmpty(partno))
                {
                    MessageBox.Show("第" + (i + 1) + "行此材料编码");
                    return;
                }
                else
                {
                    InventoryPart invpartnew = InventoryPart.FindInvInfor(partno, Site);
                    if (invpartnew != null)
                    {


                    }
                    else
                    {
                        MessageBox.Show("第" + (i + 1) + "行ERP中无此材料编码");
                        return;
                    }
                }
            }
            #endregion
            
            string appdir = System.AppDomain.CurrentDomain.BaseDirectory;
            InitializeWorkbook(@appdir+"Template\\项目MSS明细表.xls");
            ISheet sheet1 = hssfworkbook.GetSheet("MSS明细表");
            
            //create cell on rows, since rows do already exist,it's not necessary to create rows again.
            //sheet1.GetRow(1).GetCell(1).SetCellValue(200200);
            //sheet1.GetRow(2).GetCell(1).SetCellValue(300);
            //sheet1.GetRow(3).GetCell(1).SetCellValue(500050);
            //sheet1.GetRow(4).GetCell(1).SetCellValue(8000);
            int j=0, l=0;
            #region 开始循环比对Excel中的每行的库存以及申请数量
            for (int i = 0; i < dgv1.RowCount-1; i++)
            {
                
                string partno = dgv1.Rows[i].Cells[0].Value.ToString();
                if (partno.Length < 7)
                    partno = "0" + partno;

                int tt = j + 1;
                string partname,unitname;
                InventoryPart invpartnew = InventoryPart.FindInvInfor(partno, Site);
                if (invpartnew != null)
                {
                    partname = invpartnew.description;
                    unitname = invpartnew.unit_meas;

                }
                else
                {
                    MessageBox.Show("第"+i+"行ERP中无此材料编码");
                    return;
                }
                //DateTime reqdatestr = Convert.ToDateTime(dgv1.Rows[i].Cells["需求日期"].Value);
                string reqreason = dgv1.Rows[i].Cells[4].Value.ToString();
                string preQty = dgv1.Rows[i].Cells[1].Value.ToString();
                string purpose = dgv1.Rows[i].Cells[3].Value.ToString();
                string remark = dgv1.Rows[i].Cells[5].Value.ToString();
                string replaceno = "";
                InventoryPart invpart = InventoryPart.GetRequiredqty(Site, partno, ProjectId);
                decimal left_reqqty=0, reserved_qty=0;
                if (invpart != null)
                {
                   left_reqqty = Convert.ToDecimal(invpart.qty_reserved);
                   reserved_qty = Convert.ToDecimal(invpart.qty_onhand) - Convert.ToDecimal(invpart.qty_issued);

                }
                if (!string.IsNullOrEmpty(purpose))
                {
                    Str_Area = ProjectBlock.GetAreaByBlock(purpose,ProjectId,Site);
                }
                decimal needqty = Convert.ToDecimal(preQty);
                #region 如果数量不够则考虑替代码的库存以及申请情况
                if (Convert.ToDecimal(preQty) > left_reqqty + reserved_qty)
                {
                    #region 先将标准码数量写入
                    if (left_reqqty + reserved_qty > 0)
                    {
                        
                        string meo_no = GetPartMEONO(partno, preQty);
                        sheet1.GetRow(j + 5).GetCell(0).SetCellValue(tt.ToString());
                        sheet1.GetRow(j + 5).GetCell(1).SetCellValue(ProjectId);
                        sheet1.GetRow(j + 5).GetCell(2).SetCellValue(Str_Area);
                        sheet1.GetRow(j + 5).GetCell(3).SetCellValue(Str_FX);
                        sheet1.GetRow(j + 5).GetCell(4).SetCellValue(Str_Discipline);
                        sheet1.GetRow(j + 5).GetCell(5).SetCellValue(ActivityName);
                        sheet1.GetRow(j + 5).GetCell(6).SetCellValue(partno);
                        sheet1.GetRow(j + 5).GetCell(7).SetCellValue(partname);
                        sheet1.GetRow(j + 5).GetCell(9).SetCellValue((left_reqqty + reserved_qty).ToString());
                        sheet1.GetRow(j + 5).GetCell(10).SetCellValue(unitname);
                        sheet1.GetRow(j + 5).GetCell(8).SetCellValue(meo_no);
                        sheet1.GetRow(j + 5).GetCell(12).SetCellValue(reqreason);
                        sheet1.GetRow(j + 5).GetCell(17).SetCellValue(replaceno);
                        sheet1.GetRow(j + 5).GetCell(15).SetCellValue(remark);
                        sheet1.GetRow(j + 5).GetCell(16).SetCellValue(purpose);
                        j++;
                    }
                    #endregion
                    needqty = Convert.ToDecimal(preQty) - left_reqqty - reserved_qty;
                    
                    #region 替代码的库存数量以及需求数量比对
                    DataSet ReplaceDS = Ration.QueryPartRationList("select replace_no,part_description from mm_part_standard_tab where part_no ='" + partno + "'");
                    if (ReplaceDS != null)
                    {
                        int p = ReplaceDS.Tables[0].Rows.Count;
                        for (int k = 0; k < p; k++)
                        {
                            string ReplaceNo = ReplaceDS.Tables[0].Rows[k][0].ToString();
                            string ReplaceDesc = ReplaceDS.Tables[0].Rows[k][1].ToString();
                            InventoryPart invparttemp = InventoryPart.GetRequiredqty(Site, ReplaceNo, ProjectId);
                            decimal temp_left_reqqty = 0, temp_reserved_qty = 0;
                            if (invparttemp != null)
                            {
                                temp_left_reqqty = Convert.ToDecimal(invparttemp.qty_reserved);
                                temp_reserved_qty = Convert.ToDecimal(invparttemp.qty_onhand) - Convert.ToDecimal(invparttemp.qty_issued);
                                if (temp_left_reqqty + temp_reserved_qty > 0)
                                {
                                    #region 此替代码数量仍然不够
                                    if (Convert.ToDecimal(needqty) > temp_left_reqqty + temp_reserved_qty)
                                    {
                                        replaceno = replaceno + ReplaceNo + ";";
                                        needqty = needqty - temp_left_reqqty - temp_reserved_qty;
                                        string meo_no = GetPartMEONO(ReplaceNo, (temp_left_reqqty + temp_reserved_qty).ToString());
                                        sheet1.GetRow(j + 5).GetCell(0).SetCellValue(tt.ToString());
                                        sheet1.GetRow(j + 5).GetCell(1).SetCellValue(ProjectId);
                                        sheet1.GetRow(j + 5).GetCell(2).SetCellValue(Str_Area);
                                        sheet1.GetRow(j + 5).GetCell(3).SetCellValue(Str_FX);
                                        sheet1.GetRow(j + 5).GetCell(4).SetCellValue(Str_Discipline);
                                        sheet1.GetRow(j + 5).GetCell(5).SetCellValue(ActivityName);
                                        sheet1.GetRow(j + 5).GetCell(6).SetCellValue(ReplaceNo);
                                        sheet1.GetRow(j + 5).GetCell(7).SetCellValue(ReplaceDesc);
                                        sheet1.GetRow(j + 5).GetCell(9).SetCellValue((temp_left_reqqty + temp_reserved_qty).ToString());
                                        sheet1.GetRow(j + 5).GetCell(10).SetCellValue(unitname);
                                        sheet1.GetRow(j + 5).GetCell(8).SetCellValue(meo_no);
                                        sheet1.GetRow(j + 5).GetCell(12).SetCellValue(reqreason);
                                        sheet1.GetRow(j + 5).GetCell(17).SetCellValue(partno);
                                        sheet1.GetRow(j + 5).GetCell(15).SetCellValue(remark);
                                        sheet1.GetRow(j + 5).GetCell(16).SetCellValue(purpose);
                                        j++;
                                    }
                                    #endregion
                                    #region 替代码数量可以满足则跳出循环
                                    else
                                    {
                                        replaceno = replaceno + ReplaceNo + ";";
                                        string meo_no = GetPartMEONO(ReplaceNo, needqty.ToString());
                                        sheet1.GetRow(j + 5).GetCell(0).SetCellValue(tt.ToString());
                                        sheet1.GetRow(j + 5).GetCell(1).SetCellValue(ProjectId);
                                        sheet1.GetRow(j + 5).GetCell(2).SetCellValue(Str_Area);
                                        sheet1.GetRow(j + 5).GetCell(3).SetCellValue(Str_FX);
                                        sheet1.GetRow(j + 5).GetCell(4).SetCellValue(Str_Discipline);
                                        sheet1.GetRow(j + 5).GetCell(5).SetCellValue(ActivityName);
                                        sheet1.GetRow(j + 5).GetCell(6).SetCellValue(ReplaceNo);
                                        sheet1.GetRow(j + 5).GetCell(7).SetCellValue(ReplaceDesc);
                                        sheet1.GetRow(j + 5).GetCell(9).SetCellValue(needqty.ToString());
                                        sheet1.GetRow(j + 5).GetCell(10).SetCellValue(unitname);
                                        sheet1.GetRow(j + 5).GetCell(8).SetCellValue(meo_no);
                                        sheet1.GetRow(j + 5).GetCell(12).SetCellValue(reqreason);
                                        sheet1.GetRow(j + 5).GetCell(17).SetCellValue(partno);
                                        sheet1.GetRow(j + 5).GetCell(15).SetCellValue(remark);
                                        sheet1.GetRow(j + 5).GetCell(16).SetCellValue(purpose);
                                        j++;
                                        needqty = 0;
                                        
                                        break;
                                    }
                                    #endregion
                                }
                            }
                        }
                    }
                    #endregion

                }
                #endregion
                #region 如果本身库存以及申请数量足够 直接写入MEO号以及申请数量
                else
                {
                    needqty = 0;

                    string meo_no = GetPartMEONO(partno, preQty);
                    sheet1.GetRow(j + 5).GetCell(0).SetCellValue(tt.ToString());
                    sheet1.GetRow(j + 5).GetCell(1).SetCellValue(ProjectId);
                    sheet1.GetRow(j + 5).GetCell(2).SetCellValue(Str_Area);
                    sheet1.GetRow(j + 5).GetCell(3).SetCellValue(Str_FX);
                    sheet1.GetRow(j + 5).GetCell(4).SetCellValue(Str_Discipline);
                    sheet1.GetRow(j + 5).GetCell(5).SetCellValue(ActivityName);
                    sheet1.GetRow(j + 5).GetCell(6).SetCellValue(partno);
                    sheet1.GetRow(j + 5).GetCell(7).SetCellValue(partname);
                    sheet1.GetRow(j + 5).GetCell(9).SetCellValue(preQty);
                    sheet1.GetRow(j + 5).GetCell(10).SetCellValue(unitname);
                    sheet1.GetRow(j + 5).GetCell(8).SetCellValue(meo_no);
                    sheet1.GetRow(j + 5).GetCell(12).SetCellValue(reqreason);
                    sheet1.GetRow(j + 5).GetCell(17).SetCellValue(replaceno);
                    sheet1.GetRow(j + 5).GetCell(15).SetCellValue(remark);
                    sheet1.GetRow(j + 5).GetCell(16).SetCellValue(purpose);
                    j++;
                }

                #endregion

            }
            #endregion
            //Force excel to recalculate all the formula while open
            sheet1.ForceFormulaRecalculation = true;
            //create cell on rows, since rows do already exist,it's not necessary to create rows again.
            //sheet1.GetRow(1).GetCell(1).SetCellValue(200200);
            //sheet1.GetRow(2).GetCell(1).SetCellValue(300);
            //sheet1.GetRow(3).GetCell(1).SetCellValue(500050);
            //sheet1.GetRow(4).GetCell(1).SetCellValue(8000);
            
            try
            {
                WriteToFile(appdir + "\\导出的标准MSS格式\\" + "标准MSSList.xls");
                //WriteToFile(appdir + "\\导出的标准MSS格式\\" + "不足材料列表.xls");
                //MessageBox.Show("导出的标准MSS格式MSSList.xls和不足材料列表" + "成功!", "提示消息"); 
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #region 不足MSS的材料信息
            InitializeWorkbook(@appdir + "Template\\不足项目MSS明细表.xls");
            ISheet sheet2 = hssfworkbook.GetSheet("MSS明细表");
            for (int i = 0; i < dgv1.RowCount - 1; i++)
            {

                string partno = dgv1.Rows[i].Cells[0].Value.ToString();
                string partname, unitname;
                if (partno.Length < 7)
                    partno = "0" + partno;
                InventoryPart invpartnew = InventoryPart.FindInvInfor(partno, Site);
                if (invpartnew != null)
                {
                    partname = invpartnew.description;
                    unitname = invpartnew.unit_meas;

                }
                else
                {
                    MessageBox.Show("第" + i + "行ERP中无此材料编码");
                    return;
                }
                //DateTime reqdatestr = Convert.ToDateTime(dgv1.Rows[i].Cells["需求日期"].Value);
                string reqreason = dgv1.Rows[i].Cells[4].Value.ToString();
                string preQty = dgv1.Rows[i].Cells[1].Value.ToString();
                string purpose = dgv1.Rows[i].Cells[3].Value.ToString();
                string remark = dgv1.Rows[i].Cells[5].Value.ToString();
                string replaceno = "";
                InventoryPart invpart = InventoryPart.GetRequiredqty(Site, partno, ProjectId);
                decimal left_reqqty = 0, reserved_qty = 0;
                if (invpart != null)
                {
                    left_reqqty = Convert.ToDecimal(invpart.qty_reserved);
                    reserved_qty = Convert.ToDecimal(invpart.qty_onhand) - Convert.ToDecimal(invpart.qty_issued);

                }
                decimal needqty = Convert.ToDecimal(preQty);
                if (Convert.ToDecimal(preQty) > left_reqqty + reserved_qty)
                {
                    needqty = Convert.ToDecimal(preQty) - left_reqqty - reserved_qty;
                    //decimal replaceqty = 0;

                    DataSet ReplaceDS = Ration.QueryPartRationList("select replace_no from mm_part_standard_tab where part_no ='" + partno + "'");
                    if (ReplaceDS != null)
                    {
                        int p = ReplaceDS.Tables[0].Rows.Count;
                        for (int k = 0; k < p; k++)
                        {
                            string ReplaceNo = ReplaceDS.Tables[0].Rows[k][0].ToString();
                            InventoryPart invparttemp = InventoryPart.GetRequiredqty(Site, ReplaceNo, ProjectId);
                            decimal temp_left_reqqty = 0, temp_reserved_qty = 0;
                            if (invparttemp != null)
                            {
                                temp_left_reqqty = Convert.ToDecimal(invparttemp.qty_reserved);
                                temp_reserved_qty = Convert.ToDecimal(invparttemp.qty_onhand) - Convert.ToDecimal(invparttemp.qty_issued);
                                if (temp_left_reqqty + temp_reserved_qty > 0)
                                {
                                    if (Convert.ToDecimal(needqty) > temp_left_reqqty + temp_reserved_qty)
                                    {
                                        replaceno = replaceno + ReplaceNo + ";";
                                        needqty = needqty - temp_left_reqqty - temp_reserved_qty;
                                    }
                                    else
                                    {
                                        replaceno = replaceno + ReplaceNo + ";";
                                        needqty = 0;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    
                    //if (i + 5 > 10)
                    //  sheet1.CreateRow(i + 5);
                }
                else
                {
                    needqty = 0;
                }
                if (needqty == 0)
                {

                }
                else
                {
                    int tt = l + 1;
                    sheet2.GetRow(l + 5).GetCell(0).SetCellValue(tt.ToString());
                    sheet2.GetRow(l + 5).GetCell(1).SetCellValue(ProjectId);
                    sheet2.GetRow(l + 5).GetCell(2).SetCellValue(Str_Area);
                    sheet2.GetRow(l + 5).GetCell(3).SetCellValue(Str_FX);
                    sheet2.GetRow(l + 5).GetCell(4).SetCellValue(Str_Discipline);
                    sheet2.GetRow(l + 5).GetCell(5).SetCellValue(ActivityName);
                    sheet2.GetRow(l + 5).GetCell(6).SetCellValue(partno);
                    sheet2.GetRow(l + 5).GetCell(7).SetCellValue(partname);
                    sheet2.GetRow(l + 5).GetCell(9).SetCellValue(needqty.ToString());
                    sheet2.GetRow(l + 5).GetCell(10).SetCellValue(unitname);
                    //sheet2.GetRow(j + 5).GetCell(11).SetCellValue(reqdate);
                    sheet2.GetRow(l + 5).GetCell(12).SetCellValue(reqreason);
                    //sheet2.GetRow(j + 5).GetCell(13).SetCellValue(reqreason);
                    sheet2.GetRow(l + 5).GetCell(15).SetCellValue(remark);
                    sheet2.GetRow(l + 5).GetCell(16).SetCellValue(purpose);
                    //sheet1.GetRow(i + 5).GetCell(17).SetCellValue(replaceno);
                    //if (i + 5 > 14)
                    //    sheet2.CreateRow(j + 6);
                    l++;

                }

            }
            sheet2.ForceFormulaRecalculation = true;
            #endregion
            try
            {
                //WriteToFile(appdir + "\\导出的标准MSS格式\\" + "标准MSSList.xls");
                WriteToFile(appdir + "\\导出的标准MSS格式\\" + "不足材料列表.xls");
                MessageBox.Show("导出的标准MSS格式MSSList.xls和不足材料列表" + "成功!", "提示消息");
                System.Diagnostics.Process.Start("explorer.exe", appdir + "导出的标准MSS格式");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void WriteToFile(string exportpath)
        {
            //Write the stream data of workbook to the root directory
            FileStream file = new FileStream(exportpath, FileMode.Create);
            hssfworkbook.Write(file);
            file.Close();
        }
        static HSSFWorkbook hssfworkbook;
        static void InitializeWorkbook(string templatepath)
        {
            //read the template via FileStream, it is suggested to use FileAccess.Read to prevent file lock.
            //book1.xls is an Excel-2007-generated file, so some new unknown BIFF records are added. 
            FileStream file = new FileStream(templatepath, FileMode.Open, FileAccess.Read);

            hssfworkbook = new HSSFWorkbook(file);

            //create a entry of DocumentSummaryInformation
            DocumentSummaryInformation dsi = PropertySetFactory.CreateDocumentSummaryInformation();
            dsi.Company = "NPOI Team";
            hssfworkbook.DocumentSummaryInformation = dsi;

            //create a entry of SummaryInformation
            SummaryInformation si = PropertySetFactory.CreateSummaryInformation();
            si.Subject = "NPOI SDK Example";
            hssfworkbook.SummaryInformation = si;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ConvertStandard_Load(object sender, EventArgs e)
        {
            ProjectCmbItem.ProjectCmbBind(cmb_project);
            //ProjectCmbItem.ReasonCmbBind(cmb_reason);
            ProjectCmbItem.SiteCmbBind(cmb_site);
            Str_FX = XmlOper.getXMLContent("Fx");
            Str_Discipline =XmlOper.getXMLContent("Discipline");
            ActivityName = XmlOper.getXMLContent("Parttype");
        }
        private string GetPartMEONO(string part_no,string needqty)
        {
            string MEO_NO="";
            decimal avalQty = 0, reqQty = 0;
            reqQty = Convert.ToDecimal(needqty);
            string sqlstr = "select  t.p_requisition_no MEO号,t.request_qty -IFSAPP.PROJ_PROCU_RATION_API.Get_Accu_Ration_Qty(MATR_SEQ_NO) as 可用数量 from IFSAPP.PROJECT_MISC_PROCUREMENT t where PROJECT_ID = '" + ProjectId + "' and site = '" + Site + "' and issue_from_inv = 0 and PART_NO ='" + part_no + "' and (select state from ifsapp.purchase_req_line_part q where q.requisition_no =p_requisition_no and q.part_no=t.part_no) <>'Cancelled'";
            DataSet ds = PartParameter.QueryPartERPInventory(sqlstr);
            if (ds != null)
            {
                int p = ds.Tables[0].Rows.Count;
                for (int i = 0; i < p; i++)
                {
                    avalQty =Convert.ToDecimal( ds.Tables[0].Rows[i][1].ToString());
                    string TempMEONo = ds.Tables[0].Rows[i][0].ToString();
                    if (avalQty > 0)
                    {
                        if (Convert.ToDecimal(reqQty) > avalQty)
                        {
                            MEO_NO = MEO_NO + TempMEONo + ";";
                            reqQty = reqQty - avalQty;
                        }
                        else
                        {
                            MEO_NO = MEO_NO + TempMEONo + ";";
                            reqQty = 0;
                            break;
                        }
                    }
                }
                if (reqQty > 0)
                    MEO_NO = MEO_NO + GetPartReserveNO(part_no, reqQty.ToString());
                return MEO_NO.Contains(';') ? MEO_NO.Substring(0, MEO_NO.Length - 1) : MEO_NO;
            }else

                return GetPartReserveNO(part_no, reqQty.ToString());
        }
        private string GetPartReserveNO(string part_no, string needqty)
        {
            string sprojectname = ProjectId.Substring(ProjectId.Length - 3, 3);
            string MEO_NO = "";
            string sqlstrnew = "select (tt.qty_onhand - tt.qty_reserved) 可用数量,tt.req_dept 预留标识  from ifsapp.yr_inv_on_hand_vw tt WHERE tt.part_no ='" + part_no + "'   and tt.contract = '" + Site + "'   and  tt.req_dept like 'YL" + sprojectname + "%'";
            DataSet dsnew = PartParameter.QueryPartERPInventory(sqlstrnew);
            decimal avalQty = 0, reqQty = 0;
            reqQty = Convert.ToDecimal(needqty);
            if (dsnew != null)
            {
                int p = dsnew.Tables[0].Rows.Count;
                for (int i = 0; i < p; i++)
                {
                    avalQty = Convert.ToDecimal(dsnew.Tables[0].Rows[i][0].ToString());
                    string TempMEONo = dsnew.Tables[0].Rows[i][1].ToString();
                    if (avalQty > 0)
                    {
                        if (Convert.ToDecimal(reqQty) > avalQty)
                        {
                            MEO_NO = MEO_NO + TempMEONo + ";";
                            reqQty = reqQty - avalQty;
                        }
                        else
                        {
                            MEO_NO = MEO_NO + TempMEONo + ";";
                            reqQty = 0;
                            break;
                        }
                    }
                }
                return MEO_NO;
            }
            else

                return MEO_NO;

        }
    }
}