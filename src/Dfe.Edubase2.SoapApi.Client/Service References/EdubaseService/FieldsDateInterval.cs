namespace Dfe.Edubase2.SoapApi.Client.EdubaseService
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FieldsDateInterval", Namespace="http://ws.edubase.texunatech.com/DataTypes")]
    [System.SerializableAttribute()]
    public partial class FieldsDateInterval : Dfe.Edubase2.SoapApi.Client.EdubaseService.DateInterval {
        
        private Dfe.Edubase2.SoapApi.Client.EdubaseService.StringList FieldsField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
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
    }
}