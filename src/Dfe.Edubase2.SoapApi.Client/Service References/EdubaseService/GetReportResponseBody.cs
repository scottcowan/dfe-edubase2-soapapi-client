namespace Dfe.Edubase2.SoapApi.Client.EdubaseService
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://ws.edubase.texunatech.com")]
    public partial class GetReportResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public byte[] Report;
        
        public GetReportResponseBody() {
        }
        
        public GetReportResponseBody(byte[] Report) {
            this.Report = Report;
        }
    }
}