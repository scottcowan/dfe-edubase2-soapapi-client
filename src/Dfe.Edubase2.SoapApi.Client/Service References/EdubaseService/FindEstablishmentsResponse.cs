namespace Dfe.Edubase2.SoapApi.Client.EdubaseService
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="FindEstablishmentsResponse", WrapperNamespace="http://ws.edubase.texunatech.com", IsWrapped=true)]
    public partial class FindEstablishmentsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.edubase.texunatech.com", Order=0)]
        public Dfe.Edubase2.SoapApi.Client.EdubaseService.EstablishmentList Establishments;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.edubase.texunatech.com", Order=1)]
        public int PageCount;
        
        public FindEstablishmentsResponse() {
        }
        
        public FindEstablishmentsResponse(Dfe.Edubase2.SoapApi.Client.EdubaseService.EstablishmentList Establishments, int PageCount) {
            this.Establishments = Establishments;
            this.PageCount = PageCount;
        }
    }
}