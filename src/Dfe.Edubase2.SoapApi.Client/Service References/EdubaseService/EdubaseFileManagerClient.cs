namespace Dfe.Edubase2.SoapApi.Client.EdubaseService
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EdubaseFileManagerClient : System.ServiceModel.ClientBase<Dfe.Edubase2.SoapApi.Client.EdubaseService.EdubaseFileManager>, Dfe.Edubase2.SoapApi.Client.EdubaseService.EdubaseFileManager {
        
        public EdubaseFileManagerClient() {
        }
        
        public EdubaseFileManagerClient(string endpointConfigurationName) : 
            base(endpointConfigurationName) {
            }
        
        public EdubaseFileManagerClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress) {
            }
        
        public EdubaseFileManagerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress) {
            }
        
        public EdubaseFileManagerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress) {
            }
        
        public System.IO.Stream GetExtract(long Id) {
            return base.Channel.GetExtract(Id);
        }
        
        public System.Threading.Tasks.Task<System.IO.Stream> GetExtractAsync(long Id) {
            return base.Channel.GetExtractAsync(Id);
        }
        
        public System.IO.Stream GetGroupExtract() {
            return base.Channel.GetGroupExtract();
        }
        
        public System.Threading.Tasks.Task<System.IO.Stream> GetGroupExtractAsync() {
            return base.Channel.GetGroupExtractAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Dfe.Edubase2.SoapApi.Client.EdubaseService.GetReportResponse Dfe.Edubase2.SoapApi.Client.EdubaseService.EdubaseFileManager.GetReport(Dfe.Edubase2.SoapApi.Client.EdubaseService.GetReportRequest request) {
            return base.Channel.GetReport(request);
        }
        
        public byte[] GetReport(string reportKey, bool isGenerateNow, bool isZipped, Dfe.Edubase2.SoapApi.Client.EdubaseService.Map additionalParameters) {
            Dfe.Edubase2.SoapApi.Client.EdubaseService.GetReportRequest inValue = new Dfe.Edubase2.SoapApi.Client.EdubaseService.GetReportRequest();
            inValue.Body = new Dfe.Edubase2.SoapApi.Client.EdubaseService.GetReportRequestBody();
            inValue.Body.reportKey = reportKey;
            inValue.Body.isGenerateNow = isGenerateNow;
            inValue.Body.isZipped = isZipped;
            inValue.Body.additionalParameters = additionalParameters;
            Dfe.Edubase2.SoapApi.Client.EdubaseService.GetReportResponse retVal = ((Dfe.Edubase2.SoapApi.Client.EdubaseService.EdubaseFileManager)(this)).GetReport(inValue);
            return retVal.Body.Report;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Dfe.Edubase2.SoapApi.Client.EdubaseService.GetReportResponse> Dfe.Edubase2.SoapApi.Client.EdubaseService.EdubaseFileManager.GetReportAsync(Dfe.Edubase2.SoapApi.Client.EdubaseService.GetReportRequest request) {
            return base.Channel.GetReportAsync(request);
        }
        
        public System.Threading.Tasks.Task<Dfe.Edubase2.SoapApi.Client.EdubaseService.GetReportResponse> GetReportAsync(string reportKey, bool isGenerateNow, bool isZipped, Dfe.Edubase2.SoapApi.Client.EdubaseService.Map additionalParameters) {
            Dfe.Edubase2.SoapApi.Client.EdubaseService.GetReportRequest inValue = new Dfe.Edubase2.SoapApi.Client.EdubaseService.GetReportRequest();
            inValue.Body = new Dfe.Edubase2.SoapApi.Client.EdubaseService.GetReportRequestBody();
            inValue.Body.reportKey = reportKey;
            inValue.Body.isGenerateNow = isGenerateNow;
            inValue.Body.isZipped = isZipped;
            inValue.Body.additionalParameters = additionalParameters;
            return ((Dfe.Edubase2.SoapApi.Client.EdubaseService.EdubaseFileManager)(this)).GetReportAsync(inValue);
        }
    }
}