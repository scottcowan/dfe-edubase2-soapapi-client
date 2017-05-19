namespace Dfe.Edubase2.SoapApi.Client.EdubaseService
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EstablishmentFilter", Namespace="http://ws.edubase.texunatech.com/DataTypes")]
    [System.SerializableAttribute()]
    public partial class EstablishmentFilter : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int PageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Dfe.Edubase2.SoapApi.Client.EdubaseService.StringList FieldsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long? EstablishmentNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TypeOfEstablishmentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhaseOfEducationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EstablishmentStatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LAField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GovernmentOfficeRegionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EstablishmentNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Dfe.Edubase2.SoapApi.Client.EdubaseService.DateInterval OpenDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Dfe.Edubase2.SoapApi.Client.EdubaseService.DateInterval LastChangedDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Dfe.Edubase2.SoapApi.Client.EdubaseService.FieldsDateInterval FieldsChangedDateField;
        
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
        public int Page {
            get {
                return this.PageField;
            }
            set {
                if ((this.PageField.Equals(value) != true)) {
                    this.PageField = value;
                    this.RaisePropertyChanged("Page");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public Dfe.Edubase2.SoapApi.Client.EdubaseService.StringList Fields {
            get {
                return this.FieldsField;
            }
            set {
                if ((object.ReferenceEquals(this.FieldsField, value) != true)) {
                    this.FieldsField = value;
                    this.RaisePropertyChanged("Fields");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public System.Nullable<long> EstablishmentNumber {
            get {
                return this.EstablishmentNumberField;
            }
            set {
                if ((this.EstablishmentNumberField.Equals(value) != true)) {
                    this.EstablishmentNumberField = value;
                    this.RaisePropertyChanged("EstablishmentNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string TypeOfEstablishment {
            get {
                return this.TypeOfEstablishmentField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeOfEstablishmentField, value) != true)) {
                    this.TypeOfEstablishmentField = value;
                    this.RaisePropertyChanged("TypeOfEstablishment");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string PhaseOfEducation {
            get {
                return this.PhaseOfEducationField;
            }
            set {
                if ((object.ReferenceEquals(this.PhaseOfEducationField, value) != true)) {
                    this.PhaseOfEducationField = value;
                    this.RaisePropertyChanged("PhaseOfEducation");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string EstablishmentStatus {
            get {
                return this.EstablishmentStatusField;
            }
            set {
                if ((object.ReferenceEquals(this.EstablishmentStatusField, value) != true)) {
                    this.EstablishmentStatusField = value;
                    this.RaisePropertyChanged("EstablishmentStatus");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string LA {
            get {
                return this.LAField;
            }
            set {
                if ((object.ReferenceEquals(this.LAField, value) != true)) {
                    this.LAField = value;
                    this.RaisePropertyChanged("LA");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string GovernmentOfficeRegion {
            get {
                return this.GovernmentOfficeRegionField;
            }
            set {
                if ((object.ReferenceEquals(this.GovernmentOfficeRegionField, value) != true)) {
                    this.GovernmentOfficeRegionField = value;
                    this.RaisePropertyChanged("GovernmentOfficeRegion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string EstablishmentName {
            get {
                return this.EstablishmentNameField;
            }
            set {
                if ((object.ReferenceEquals(this.EstablishmentNameField, value) != true)) {
                    this.EstablishmentNameField = value;
                    this.RaisePropertyChanged("EstablishmentName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=9)]
        public Dfe.Edubase2.SoapApi.Client.EdubaseService.DateInterval OpenDate {
            get {
                return this.OpenDateField;
            }
            set {
                if ((object.ReferenceEquals(this.OpenDateField, value) != true)) {
                    this.OpenDateField = value;
                    this.RaisePropertyChanged("OpenDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=10)]
        public Dfe.Edubase2.SoapApi.Client.EdubaseService.DateInterval LastChangedDate {
            get {
                return this.LastChangedDateField;
            }
            set {
                if ((object.ReferenceEquals(this.LastChangedDateField, value) != true)) {
                    this.LastChangedDateField = value;
                    this.RaisePropertyChanged("LastChangedDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=11)]
        public Dfe.Edubase2.SoapApi.Client.EdubaseService.FieldsDateInterval FieldsChangedDate {
            get {
                return this.FieldsChangedDateField;
            }
            set {
                if ((object.ReferenceEquals(this.FieldsChangedDateField, value) != true)) {
                    this.FieldsChangedDateField = value;
                    this.RaisePropertyChanged("FieldsChangedDate");
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