namespace Dfe.Edubase2.SoapApi.Client.EdubaseService
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ws.edubase.texunatech.com", ConfigurationName="EdubaseService.EdubaseFileManager")]
    public interface EdubaseFileManager {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.edubase.texunatech.com/GetExtract", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Dfe.Edubase2.SoapApi.Client.EdubaseService.ValidationFault), Action="http://ws.edubase.texunatech.com/GetExtract", Name="ValidationFault")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Extract")]
        System.IO.Stream GetExtract(long Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.edubase.texunatech.com/GetExtract", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Extract")]
        System.Threading.Tasks.Task<System.IO.Stream> GetExtractAsync(long Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.edubase.texunatech.com/GetGroupExtract", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Dfe.Edubase2.SoapApi.Client.EdubaseService.ValidationFault), Action="http://ws.edubase.texunatech.com/GetGroupExtract", Name="ValidationFault")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Extract")]
        System.IO.Stream GetGroupExtract();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.edubase.texunatech.com/GetGroupExtract", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Extract")]
        System.Threading.Tasks.Task<System.IO.Stream> GetGroupExtractAsync();
        
        // CODEGEN: Generating message contract since element name reportKey from namespace http://ws.edubase.texunatech.com is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.edubase.texunatech.com/GetReport", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Dfe.Edubase2.SoapApi.Client.EdubaseService.ValidationFault), Action="http://ws.edubase.texunatech.com/GetReport", Name="ValidationFault")]
        Dfe.Edubase2.SoapApi.Client.EdubaseService.GetReportResponse GetReport(Dfe.Edubase2.SoapApi.Client.EdubaseService.GetReportRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.edubase.texunatech.com/GetReport", ReplyAction="*")]
        System.Threading.Tasks.Task<Dfe.Edubase2.SoapApi.Client.EdubaseService.GetReportResponse> GetReportAsync(Dfe.Edubase2.SoapApi.Client.EdubaseService.GetReportRequest request);
    }
}