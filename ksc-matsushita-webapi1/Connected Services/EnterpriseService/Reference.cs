﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ksc_matsushita_webapi1.EnterpriseService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://enterprise.yzk.ranalex.com", ConfigurationName="EnterpriseService.EnterpriseServicePortType")]
    public interface EnterpriseServicePortType {
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:service", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ksc_matsushita_webapi1.EnterpriseService.serviceResponse service(ksc_matsushita_webapi1.EnterpriseService.serviceRequest request);
        
        // CODEGEN: 操作に複数の戻り値があるため、メッセージ コントラクトを生成しています。
        [System.ServiceModel.OperationContractAttribute(Action="urn:service", ReplyAction="*")]
        System.Threading.Tasks.Task<ksc_matsushita_webapi1.EnterpriseService.serviceResponse> serviceAsync(ksc_matsushita_webapi1.EnterpriseService.serviceRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3190.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://enterprise.yzk.ranalex.com")]
    public partial class DataAccess : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string damlField;
        
        private string operationIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string daml {
            get {
                return this.damlField;
            }
            set {
                this.damlField = value;
                this.RaisePropertyChanged("daml");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string operationId {
            get {
                return this.operationIdField;
            }
            set {
                this.operationIdField = value;
                this.RaisePropertyChanged("operationId");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3190.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://enterprise.yzk.ranalex.com")]
    public partial class DataAccessResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private DataTable dataTableField;
        
        private string exceptionField;
        
        private string operationIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public DataTable DataTable {
            get {
                return this.dataTableField;
            }
            set {
                this.dataTableField = value;
                this.RaisePropertyChanged("DataTable");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Exception {
            get {
                return this.exceptionField;
            }
            set {
                this.exceptionField = value;
                this.RaisePropertyChanged("Exception");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string operationId {
            get {
                return this.operationIdField;
            }
            set {
                this.operationIdField = value;
                this.RaisePropertyChanged("operationId");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3190.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://enterprise.yzk.ranalex.com")]
    public partial class DataTable : object, System.ComponentModel.INotifyPropertyChanged {
        
        private DataTableColumn[] columnsField;
        
        private DataTableRows rowsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Column", IsNullable=false)]
        public DataTableColumn[] Columns {
            get {
                return this.columnsField;
            }
            set {
                this.columnsField = value;
                this.RaisePropertyChanged("Columns");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public DataTableRows Rows {
            get {
                return this.rowsField;
            }
            set {
                this.rowsField = value;
                this.RaisePropertyChanged("Rows");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3190.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://enterprise.yzk.ranalex.com")]
    public partial class DataTableColumn : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string nameField;
        
        private string classField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("name");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @class {
            get {
                return this.classField;
            }
            set {
                this.classField = value;
                this.RaisePropertyChanged("class");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3190.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://enterprise.yzk.ranalex.com")]
    public partial class DataTableRows : object, System.ComponentModel.INotifyPropertyChanged {
        
        private DataTableRowsRow[] rowField;
        
        private string countField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Row", Order=0)]
        public DataTableRowsRow[] Row {
            get {
                return this.rowField;
            }
            set {
                this.rowField = value;
                this.RaisePropertyChanged("Row");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string count {
            get {
                return this.countField;
            }
            set {
                this.countField = value;
                this.RaisePropertyChanged("count");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3190.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://enterprise.yzk.ranalex.com")]
    public partial class DataTableRowsRow : object, System.ComponentModel.INotifyPropertyChanged {
        
        private DataTableRowsRowCell[] cellField;
        
        private string indexField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cell", Order=0)]
        public DataTableRowsRowCell[] Cell {
            get {
                return this.cellField;
            }
            set {
                this.cellField = value;
                this.RaisePropertyChanged("Cell");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string index {
            get {
                return this.indexField;
            }
            set {
                this.indexField = value;
                this.RaisePropertyChanged("index");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3190.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://enterprise.yzk.ranalex.com")]
    public partial class DataTableRowsRowCell : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string indexField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string index {
            get {
                return this.indexField;
            }
            set {
                this.indexField = value;
                this.RaisePropertyChanged("index");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
                this.RaisePropertyChanged("Value");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="service", WrapperNamespace="http://enterprise.yzk.ranalex.com", IsWrapped=true)]
    public partial class serviceRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://enterprise.yzk.ranalex.com", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("DataAccess")]
        public ksc_matsushita_webapi1.EnterpriseService.DataAccess[] DataAccess;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://enterprise.yzk.ranalex.com", Order=1)]
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string clientId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://enterprise.yzk.ranalex.com", Order=2)]
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string requestId;
        
        public serviceRequest() {
        }
        
        public serviceRequest(ksc_matsushita_webapi1.EnterpriseService.DataAccess[] DataAccess, string clientId, string requestId) {
            this.DataAccess = DataAccess;
            this.clientId = clientId;
            this.requestId = requestId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="serviceResponse", WrapperNamespace="http://enterprise.yzk.ranalex.com", IsWrapped=true)]
    public partial class serviceResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://enterprise.yzk.ranalex.com", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("DataAccessResponse")]
        public ksc_matsushita_webapi1.EnterpriseService.DataAccessResponse[] DataAccessResponse;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://enterprise.yzk.ranalex.com", Order=1)]
        public string Exception;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://enterprise.yzk.ranalex.com", Order=2)]
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string clientId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://enterprise.yzk.ranalex.com", Order=3)]
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string requestId;
        
        public serviceResponse() {
        }
        
        public serviceResponse(ksc_matsushita_webapi1.EnterpriseService.DataAccessResponse[] DataAccessResponse, string Exception, string clientId, string requestId) {
            this.DataAccessResponse = DataAccessResponse;
            this.Exception = Exception;
            this.clientId = clientId;
            this.requestId = requestId;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface EnterpriseServicePortTypeChannel : ksc_matsushita_webapi1.EnterpriseService.EnterpriseServicePortType, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EnterpriseServicePortTypeClient : System.ServiceModel.ClientBase<ksc_matsushita_webapi1.EnterpriseService.EnterpriseServicePortType>, ksc_matsushita_webapi1.EnterpriseService.EnterpriseServicePortType {
        
        public EnterpriseServicePortTypeClient() {
        }
        
        public EnterpriseServicePortTypeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EnterpriseServicePortTypeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EnterpriseServicePortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EnterpriseServicePortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ksc_matsushita_webapi1.EnterpriseService.serviceResponse ksc_matsushita_webapi1.EnterpriseService.EnterpriseServicePortType.service(ksc_matsushita_webapi1.EnterpriseService.serviceRequest request) {
            return base.Channel.service(request);
        }
        
        public ksc_matsushita_webapi1.EnterpriseService.DataAccessResponse[] service(ksc_matsushita_webapi1.EnterpriseService.DataAccess[] DataAccess, ref string clientId, ref string requestId, out string Exception) {
            ksc_matsushita_webapi1.EnterpriseService.serviceRequest inValue = new ksc_matsushita_webapi1.EnterpriseService.serviceRequest();
            inValue.DataAccess = DataAccess;
            inValue.clientId = clientId;
            inValue.requestId = requestId;
            ksc_matsushita_webapi1.EnterpriseService.serviceResponse retVal = ((ksc_matsushita_webapi1.EnterpriseService.EnterpriseServicePortType)(this)).service(inValue);
            Exception = retVal.Exception;
            clientId = retVal.clientId;
            requestId = retVal.requestId;
            return retVal.DataAccessResponse;
        }
        
        public System.Threading.Tasks.Task<ksc_matsushita_webapi1.EnterpriseService.serviceResponse> serviceAsync(ksc_matsushita_webapi1.EnterpriseService.serviceRequest request) {
            return base.Channel.serviceAsync(request);
        }
    }
}
