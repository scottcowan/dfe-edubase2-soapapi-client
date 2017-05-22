using System.ServiceModel;
using System.ServiceModel.Description;
using System.Threading.Tasks;

namespace Dfe.Edubase2.SoapApi.Client.EdubaseService
{
    public interface IEdubaseClient
    {
        ChannelFactory<Edubase> ChannelFactory { get; }
        ClientCredentials ClientCredentials { get; }
        CommunicationState State { get; }
        IClientChannel InnerChannel { get; }
        ServiceEndpoint Endpoint { get; }
        Establishment GetEstablishment(long Urn);
        Task<Establishment> GetEstablishmentAsync(long Urn);
        EstablishmentList FindEstablishments(EstablishmentFilter Filter, out int PageCount);
        Task<FindEstablishmentsResponse> FindEstablishmentsAsync(FindEstablishmentsRequest request);
        void Open();
        void Abort();
        void Close();
        void DisplayInitializationUI();
    }
}