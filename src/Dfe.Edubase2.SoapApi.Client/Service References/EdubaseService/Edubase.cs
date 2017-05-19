namespace Dfe.Edubase2.SoapApi.Client.EdubaseService
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ws.edubase.texunatech.com", ConfigurationName="EdubaseService.Edubase")]
    public interface Edubase {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.edubase.texunatech.com/GetEstablishment", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Dfe.Edubase2.SoapApi.Client.EdubaseService.ValidationFault), Action="http://ws.edubase.texunatech.com/GetEstablishment", Name="ValidationFault")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Establishment")]
        Dfe.Edubase2.SoapApi.Client.EdubaseService.Establishment GetEstablishment(long Urn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.edubase.texunatech.com/GetEstablishment", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="Establishment")]
        System.Threading.Tasks.Task<Dfe.Edubase2.SoapApi.Client.EdubaseService.Establishment> GetEstablishmentAsync(long Urn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.edubase.texunatech.com/FindEstablishments", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(Dfe.Edubase2.SoapApi.Client.EdubaseService.ValidationFault), Action="http://ws.edubase.texunatech.com/FindEstablishments", Name="ValidationFault")]
        Dfe.Edubase2.SoapApi.Client.EdubaseService.FindEstablishmentsResponse FindEstablishments(Dfe.Edubase2.SoapApi.Client.EdubaseService.FindEstablishmentsRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.edubase.texunatech.com/FindEstablishments", ReplyAction="*")]
        System.Threading.Tasks.Task<Dfe.Edubase2.SoapApi.Client.EdubaseService.FindEstablishmentsResponse> FindEstablishmentsAsync(Dfe.Edubase2.SoapApi.Client.EdubaseService.FindEstablishmentsRequest request);
    }
}