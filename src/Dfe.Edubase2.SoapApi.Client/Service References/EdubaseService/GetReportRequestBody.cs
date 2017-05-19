namespace Dfe.Edubase2.SoapApi.Client.EdubaseService
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://ws.edubase.texunatech.com")]
    public partial class GetReportRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string reportKey;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public bool isGenerateNow;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public bool isZipped;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public Dfe.Edubase2.SoapApi.Client.EdubaseService.Map additionalParameters;
        
        public GetReportRequestBody() {
        }
        
        public GetReportRequestBody(string reportKey, bool isGenerateNow, bool isZipped, Dfe.Edubase2.SoapApi.Client.EdubaseService.Map additionalParameters) {
            this.reportKey = reportKey;
            this.isGenerateNow = isGenerateNow;
            this.isZipped = isZipped;
            this.additionalParameters = additionalParameters;
        }
    }
}