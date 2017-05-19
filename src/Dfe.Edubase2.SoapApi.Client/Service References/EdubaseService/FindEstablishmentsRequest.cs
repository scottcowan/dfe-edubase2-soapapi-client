namespace Dfe.Edubase2.SoapApi.Client.EdubaseService
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="FindEstablishments", WrapperNamespace="http://ws.edubase.texunatech.com", IsWrapped=true)]
    public partial class FindEstablishmentsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.edubase.texunatech.com", Order=0)]
        public Dfe.Edubase2.SoapApi.Client.EdubaseService.EstablishmentFilter Filter;
        
        public FindEstablishmentsRequest() {
        }
        
        public FindEstablishmentsRequest(Dfe.Edubase2.SoapApi.Client.EdubaseService.EstablishmentFilter Filter) {
            this.Filter = Filter;
        }
    }
}