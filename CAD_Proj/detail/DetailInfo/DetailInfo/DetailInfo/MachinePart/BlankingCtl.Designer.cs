﻿namespace DetailInfo
{
    partial class BlankingCtl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.项目号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.图纸号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.分段号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.系统名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.系统代码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.小票号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.规格 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.重量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.处理方式 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.发图时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.下料人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.下料日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.下料完成ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.导出ExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.项目号,
            this.图纸号,
            this.分段号,
            this.系统名称,
            this.系统代码,
            this.小票号,
            this.规格,
            this.重量,
            this.处理方式,
            this.发图时间,
            this.下料人,
            this.下料日期});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(943, 396);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseUp);
            // 
            // 项目号
            // 
            this.项目号.DataPropertyName = "PROJECTID";
            this.项目号.HeaderText = "项目号";
            this.项目号.Name = "项目号";
            this.项目号.Width = 68;
            // 
            // 图纸号
            // 
            this.图纸号.DataPropertyName = "DRAWINGNO";
            this.图纸号.HeaderText = "图纸号";
            this.图纸号.Name = "图纸号";
            this.图纸号.Width = 68;
            // 
            // 分段号
            // 
            this.分段号.DataPropertyName = "BLOCKNO";
            this.分段号.HeaderText = "分段号";
            this.分段号.Name = "分段号";
            this.分段号.Width = 68;
            // 
            // 系统名称
            // 
            this.系统名称.DataPropertyName = "SYSTEMNAME";
            this.系统名称.HeaderText = "系统名称";
            this.系统名称.Name = "系统名称";
            this.系统名称.Width = 80;
            // 
            // 系统代码
            // 
            this.系统代码.DataPropertyName = "SYSTEMID";
            this.系统代码.HeaderText = "系统代码";
            this.系统代码.Name = "系统代码";
            this.系统代码.Width = 80;
            // 
            // 小票号
            // 
            this.小票号.DataPropertyName = "SPOOLNAME";
            this.小票号.HeaderText = "小票号";
            this.小票号.Name = "小票号";
            this.小票号.Width = 68;
            // 
            // 规格
            // 
            this.规格.DataPropertyName = "NORM";
            this.规格.HeaderText = "管径/壁厚";
            this.规格.Name = "规格";
            this.规格.Width = 85;
            // 
            // 重量
            // 
            this.重量.DataPropertyName = "SPOOLWEIGHT";
            this.重量.HeaderText = "重量(kg)";
            this.重量.Name = "重量";
            this.重量.Width = 74;
            // 
            // 处理方式
            // 
            this.处理方式.DataPropertyName = "SURFACETREATMENT";
            this.处理方式.HeaderText = "处理方式";
            this.处理方式.Name = "处理方式";
            this.处理方式.Width = 80;
            // 
            // 发图时间
            // 
            this.发图时间.DataPropertyName = "ISSUED_TIME";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.发图时间.DefaultCellStyle = dataGridViewCellStyle2;
            this.发图时间.HeaderText = "发图时间";
            this.发图时间.Name = "发图时间";
            this.发图时间.Width = 80;
            // 
            // 下料人
            // 
            this.下料人.DataPropertyName = "BLANKINGPERSON";
            this.下料人.HeaderText = "下料人";
            this.下料人.Name = "下料人";
            this.下料人.Width = 68;
            // 
            // 下料日期
            // 
            this.下料日期.DataPropertyName = "BLANKINGDATE";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.下料日期.DefaultCellStyle = dataGridViewCellStyle3;
            this.下料日期.HeaderText = "下料日期";
            this.下料日期.Name = "下料日期";
            this.下料日期.Width = 80;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.下料完成ToolStripMenuItem,
            this.toolStripSeparator1,
            this.导出ExcelToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(124, 54);
            // 
            // 下料完成ToolStripMenuItem
            // 
            this.下料完成ToolStripMenuItem.Name = "下料完成ToolStripMenuItem";
            this.下料完成ToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.下料完成ToolStripMenuItem.Text = "下料完成";
            this.下料完成ToolStripMenuItem.Visible = false;
            this.下料完成ToolStripMenuItem.Click += new System.EventHandler(this.下料完成ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(120, 6);
            this.toolStripSeparator1.Visible = false;
            // 
            // 导出ExcelToolStripMenuItem
            // 
            this.导出ExcelToolStripMenuItem.Name = "导出ExcelToolStripMenuItem";
            this.导出ExcelToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.导出ExcelToolStripMenuItem.Text = "导出Excel";
            this.导出ExcelToolStripMenuItem.Visible = false;
            this.导出ExcelToolStripMenuItem.Click += new System.EventHandler(this.导出ExcelToolStripMenuItem_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(3, 37);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Visible = false;
            // 
            // BlankingCtl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.progressBar1);
            this.Name = "BlankingCtl";
            this.Size = new System.Drawing.Size(943, 396);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 下料完成ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 导出ExcelToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 项目号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 图纸号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 分段号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 系统名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 系统代码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 小票号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 规格;
        private System.Windows.Forms.DataGridViewTextBoxColumn 重量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 处理方式;
        private System.Windows.Forms.DataGridViewTextBoxColumn 发图时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 下料人;
        private System.Windows.Forms.DataGridViewTextBoxColumn 下料日期;
    }
}
