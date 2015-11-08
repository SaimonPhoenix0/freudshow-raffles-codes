﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:2.0.50727.3053
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 此源代码是由 Microsoft.VSDesigner 2.0.50727.3053 版自动生成。
// 
#pragma warning disable 1591

namespace mFormTest.mWebRef {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="DrawingSoap", Namespace="http://tempuri.org/")]
    public partial class Drawing : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetApproveTemplateOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetApproveTemplateNewOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetDrawingTemplateInfoOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetDrawingInfoOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetIFCDrawingCountsOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Drawing() {
            this.Url = global::mFormTest.Properties.Settings.Default.mFormTest_mWebRef_Drawing;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetApproveTemplateCompletedEventHandler GetApproveTemplateCompleted;
        
        /// <remarks/>
        public event GetApproveTemplateNewCompletedEventHandler GetApproveTemplateNewCompleted;
        
        /// <remarks/>
        public event GetDrawingTemplateInfoCompletedEventHandler GetDrawingTemplateInfoCompleted;
        
        /// <remarks/>
        public event GetDrawingInfoCompletedEventHandler GetDrawingInfoCompleted;
        
        /// <remarks/>
        public event GetIFCDrawingCountsCompletedEventHandler GetIFCDrawingCountsCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetApproveTemplate", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetApproveTemplate(string drawnICNo, string drawingNo, string rev) {
            object[] results = this.Invoke("GetApproveTemplate", new object[] {
                        drawnICNo,
                        drawingNo,
                        rev});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetApproveTemplateAsync(string drawnICNo, string drawingNo, string rev) {
            this.GetApproveTemplateAsync(drawnICNo, drawingNo, rev, null);
        }
        
        /// <remarks/>
        public void GetApproveTemplateAsync(string drawnICNo, string drawingNo, string rev, object userState) {
            if ((this.GetApproveTemplateOperationCompleted == null)) {
                this.GetApproveTemplateOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetApproveTemplateOperationCompleted);
            }
            this.InvokeAsync("GetApproveTemplate", new object[] {
                        drawnICNo,
                        drawingNo,
                        rev}, this.GetApproveTemplateOperationCompleted, userState);
        }
        
        private void OnGetApproveTemplateOperationCompleted(object arg) {
            if ((this.GetApproveTemplateCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetApproveTemplateCompleted(this, new GetApproveTemplateCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetApproveTemplateNew", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetApproveTemplateNew(string drawnICNo, string drawingNo, string rev) {
            object[] results = this.Invoke("GetApproveTemplateNew", new object[] {
                        drawnICNo,
                        drawingNo,
                        rev});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetApproveTemplateNewAsync(string drawnICNo, string drawingNo, string rev) {
            this.GetApproveTemplateNewAsync(drawnICNo, drawingNo, rev, null);
        }
        
        /// <remarks/>
        public void GetApproveTemplateNewAsync(string drawnICNo, string drawingNo, string rev, object userState) {
            if ((this.GetApproveTemplateNewOperationCompleted == null)) {
                this.GetApproveTemplateNewOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetApproveTemplateNewOperationCompleted);
            }
            this.InvokeAsync("GetApproveTemplateNew", new object[] {
                        drawnICNo,
                        drawingNo,
                        rev}, this.GetApproveTemplateNewOperationCompleted, userState);
        }
        
        private void OnGetApproveTemplateNewOperationCompleted(object arg) {
            if ((this.GetApproveTemplateNewCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetApproveTemplateNewCompleted(this, new GetApproveTemplateNewCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetDrawingTemplateInfo", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetDrawingTemplateInfo(string drawingNo, string rev) {
            object[] results = this.Invoke("GetDrawingTemplateInfo", new object[] {
                        drawingNo,
                        rev});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetDrawingTemplateInfoAsync(string drawingNo, string rev) {
            this.GetDrawingTemplateInfoAsync(drawingNo, rev, null);
        }
        
        /// <remarks/>
        public void GetDrawingTemplateInfoAsync(string drawingNo, string rev, object userState) {
            if ((this.GetDrawingTemplateInfoOperationCompleted == null)) {
                this.GetDrawingTemplateInfoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetDrawingTemplateInfoOperationCompleted);
            }
            this.InvokeAsync("GetDrawingTemplateInfo", new object[] {
                        drawingNo,
                        rev}, this.GetDrawingTemplateInfoOperationCompleted, userState);
        }
        
        private void OnGetDrawingTemplateInfoOperationCompleted(object arg) {
            if ((this.GetDrawingTemplateInfoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetDrawingTemplateInfoCompleted(this, new GetDrawingTemplateInfoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetDrawingInfo", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetDrawingInfo(string projectName, string drawingNo, string rev) {
            object[] results = this.Invoke("GetDrawingInfo", new object[] {
                        projectName,
                        drawingNo,
                        rev});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetDrawingInfoAsync(string projectName, string drawingNo, string rev) {
            this.GetDrawingInfoAsync(projectName, drawingNo, rev, null);
        }
        
        /// <remarks/>
        public void GetDrawingInfoAsync(string projectName, string drawingNo, string rev, object userState) {
            if ((this.GetDrawingInfoOperationCompleted == null)) {
                this.GetDrawingInfoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetDrawingInfoOperationCompleted);
            }
            this.InvokeAsync("GetDrawingInfo", new object[] {
                        projectName,
                        drawingNo,
                        rev}, this.GetDrawingInfoOperationCompleted, userState);
        }
        
        private void OnGetDrawingInfoOperationCompleted(object arg) {
            if ((this.GetDrawingInfoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetDrawingInfoCompleted(this, new GetDrawingInfoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetIFCDrawingCounts", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetIFCDrawingCounts(string projectName, string drawingType) {
            object[] results = this.Invoke("GetIFCDrawingCounts", new object[] {
                        projectName,
                        drawingType});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetIFCDrawingCountsAsync(string projectName, string drawingType) {
            this.GetIFCDrawingCountsAsync(projectName, drawingType, null);
        }
        
        /// <remarks/>
        public void GetIFCDrawingCountsAsync(string projectName, string drawingType, object userState) {
            if ((this.GetIFCDrawingCountsOperationCompleted == null)) {
                this.GetIFCDrawingCountsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetIFCDrawingCountsOperationCompleted);
            }
            this.InvokeAsync("GetIFCDrawingCounts", new object[] {
                        projectName,
                        drawingType}, this.GetIFCDrawingCountsOperationCompleted, userState);
        }
        
        private void OnGetIFCDrawingCountsOperationCompleted(object arg) {
            if ((this.GetIFCDrawingCountsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetIFCDrawingCountsCompleted(this, new GetIFCDrawingCountsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void GetApproveTemplateCompletedEventHandler(object sender, GetApproveTemplateCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetApproveTemplateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetApproveTemplateCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void GetApproveTemplateNewCompletedEventHandler(object sender, GetApproveTemplateNewCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetApproveTemplateNewCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetApproveTemplateNewCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void GetDrawingTemplateInfoCompletedEventHandler(object sender, GetDrawingTemplateInfoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetDrawingTemplateInfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetDrawingTemplateInfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void GetDrawingInfoCompletedEventHandler(object sender, GetDrawingInfoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetDrawingInfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetDrawingInfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void GetIFCDrawingCountsCompletedEventHandler(object sender, GetIFCDrawingCountsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetIFCDrawingCountsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetIFCDrawingCountsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591