namespace Dfe.Edubase2.SoapApi.Client.EdubaseService
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetReportRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetReport", Namespace="http://ws.edubase.texunatech.com", Order=0)]
        public Dfe.Edubase2.SoapApi.Client.EdubaseService.GetReportRequestBody Body;
        
        public GetReportRequest() {
        }
        
        public GetReportRequest(Dfe.Edubase2.SoapApi.Client.EdubaseService.GetReportRequestBody Body) {
            this.Body = Body;
        }
    }
}