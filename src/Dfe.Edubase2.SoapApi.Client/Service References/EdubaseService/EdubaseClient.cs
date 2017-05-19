namespace Dfe.Edubase2.SoapApi.Client.EdubaseService
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    internal class EdubaseClient : System.ServiceModel.ClientBase<Dfe.Edubase2.SoapApi.Client.EdubaseService.Edubase>, Dfe.Edubase2.SoapApi.Client.EdubaseService.Edubase {
        
        public EdubaseClient() {
        }
        
        public EdubaseClient(string endpointConfigurationName) : 
            base(endpointConfigurationName) {
            }
        
        public EdubaseClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress) {
            }
        
        public EdubaseClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress) {
            }
        
        public EdubaseClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress) {
            }
        
        public Dfe.Edubase2.SoapApi.Client.EdubaseService.Establishment GetEstablishment(long Urn) {
            return base.Channel.GetEstablishment(Urn);
        }
        
        public System.Threading.Tasks.Task<Dfe.Edubase2.SoapApi.Client.EdubaseService.Establishment> GetEstablishmentAsync(long Urn) {
            return base.Channel.GetEstablishmentAsync(Urn);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Dfe.Edubase2.SoapApi.Client.EdubaseService.FindEstablishmentsResponse Dfe.Edubase2.SoapApi.Client.EdubaseService.Edubase.FindEstablishments(Dfe.Edubase2.SoapApi.Client.EdubaseService.FindEstablishmentsRequest request) {
            return base.Channel.FindEstablishments(request);
        }
        
        public Dfe.Edubase2.SoapApi.Client.EdubaseService.EstablishmentList FindEstablishments(Dfe.Edubase2.SoapApi.Client.EdubaseService.EstablishmentFilter Filter, out int PageCount) {
            Dfe.Edubase2.SoapApi.Client.EdubaseService.FindEstablishmentsRequest inValue = new Dfe.Edubase2.SoapApi.Client.EdubaseService.FindEstablishmentsRequest();
            inValue.Filter = Filter;
            Dfe.Edubase2.SoapApi.Client.EdubaseService.FindEstablishmentsResponse retVal = ((Dfe.Edubase2.SoapApi.Client.EdubaseService.Edubase)(this)).FindEstablishments(inValue);
            PageCount = retVal.PageCount;
            return retVal.Establishments;
        }
        
        public System.Threading.Tasks.Task<Dfe.Edubase2.SoapApi.Client.EdubaseService.FindEstablishmentsResponse> FindEstablishmentsAsync(Dfe.Edubase2.SoapApi.Client.EdubaseService.FindEstablishmentsRequest request) {
            return base.Channel.FindEstablishmentsAsync(request);
        }
    }
}