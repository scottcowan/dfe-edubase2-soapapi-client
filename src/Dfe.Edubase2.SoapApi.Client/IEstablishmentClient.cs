using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dfe.Edubase2.SoapApi.Client.EdubaseService;

namespace Dfe.Edubase2.SoapApi.Client
{
    public interface IEstablishmentClient
    {
        /// <summary>
        /// An action run before each query to allow it to be logged
        /// </summary>
        Action<EstablishmentFilter> PreRequest { get; set; }

        /// <summary>
        /// An action run after a response has been received
        /// </summary>
        Action<EstablishmentFilter, FindEstablishmentsResponse> PostRequestAsync { get; set; }

        Action<EstablishmentFilter, EstablishmentList> PostRequest { get; set; }

        IEnumerable<Establishment> FindEstablishments(EstablishmentFilter filter = null);
        Task<List<Establishment>> FindEstablishmentsAsync(EstablishmentFilter filter = null);
        Establishment GetEstablishment(long urn);
        Task<Establishment> GetEstablishmentAsync(long urn);
    }
}