namespace Dfe.Edubase2.SoapApi.Client.EdubaseService
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EstablishmentLink", Namespace="http://ws.edubase.texunatech.com/Establishment")]
    [System.SerializableAttribute()]
    public partial class EstablishmentLink : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private long LinkUrnField;
        
        private System.Nullable<System.DateTime> EstablishedDateField;
        
        private Dfe.Edubase2.SoapApi.Client.EdubaseService.Dictionary LinkTypeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public long LinkUrn {
            get {
                return this.LinkUrnField;
            }
            set {
                if ((this.LinkUrnField.Equals(value) != true)) {
                    this.LinkUrnField = value;
                    this.RaisePropertyChanged("LinkUrn");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
        public System.Nullable<System.DateTime> EstablishedDate {
            get {
                return this.EstablishedDateField;
            }
            set {
                if ((this.EstablishedDateField.Equals(value) != true)) {
                    this.EstablishedDateField = value;
                    this.RaisePropertyChanged("EstablishedDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false, Order=2)]
        public Dfe.Edubase2.SoapApi.Client.EdubaseService.Dictionary LinkType {
            get {
                return this.LinkTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.LinkTypeField, value) != true)) {
                    this.LinkTypeField = value;
                    this.RaisePropertyChanged("LinkType");
                }
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
}