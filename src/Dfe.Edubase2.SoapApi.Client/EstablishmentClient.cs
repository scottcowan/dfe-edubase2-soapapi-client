using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dfe.Edubase2.SoapApi.Client.EdubaseService;

namespace Dfe.Edubase2.SoapApi.Client
{
    public class EstablishmentClient : IEstablishmentClient
    {
        private readonly IEdubaseClient _client;

        public EstablishmentClient(string username, string password) : this(CreateEdubaseClient(username, password))
        {
        }

        internal EstablishmentClient(IEdubaseClient client)
        {
            _client = client;
        }

        /// <summary>
        /// An action run before each query to allow it to be logged
        /// </summary>
        public Action<EstablishmentFilter> PreRequest { get; set; }

        /// <summary>
        /// An action run after a response has been received
        /// </summary>
        public Action<EstablishmentFilter, FindEstablishmentsResponse> PostRequestAsync { get; set; }

        public Action<EstablishmentFilter, EstablishmentList> PostRequest { get; set; }


        public IEnumerable<Establishment> FindEstablishments(EstablishmentFilter filter = null)
        {
            int pages;
            filter = filter ?? new EstablishmentFilter();
            filter.Page = 0;
            PreRequest?.Invoke(filter);
            var response = _client.FindEstablishments(filter, out pages);
            PostRequest?.Invoke(filter, response);

            foreach (var establishment in response)
            {
                yield return establishment;
            }

            for (var i = 1; i < pages; i++)
            {
                filter.Page = i;

                PreRequest?.Invoke(filter);
                response = _client.FindEstablishments(filter, out pages);
                PostRequest?.Invoke(filter, response);

                foreach (var establishment in response)
                {
                    yield return establishment;
                }
            }
        }

        public async Task<List<Establishment>> FindEstablishmentsAsync(EstablishmentFilter filter = null)
        {
            var list = new List<Establishment>();
            filter = filter ?? new EstablishmentFilter();
            filter.Page = 0;
            var response = await RequestEstablishments(filter);

            list.AddRange(response.Establishments);
            for (var i = 1; i < response.PageCount; i++)
            {
                filter.Page = i;
                list.AddRange((await RequestEstablishments(filter)).Establishments);
            }

            return list;
        }

        private async Task<FindEstablishmentsResponse> RequestEstablishments(EstablishmentFilter filter)
        {
            PreRequest?.Invoke(filter);
            var response = await _client.FindEstablishmentsAsync(new FindEstablishmentsRequest(filter));
            PostRequestAsync?.Invoke(filter, response);
            return response;
        }

        public Establishment GetEstablishment(long urn)
        {
            return _client.GetEstablishment(urn);
        }

        public async Task<Establishment> GetEstablishmentAsync(long urn)
        {
            return await _client.GetEstablishmentAsync(urn);
        }

        private static EdubaseClient CreateEdubaseClient(string username, string password)
        {
            var client = new EdubaseClient("EdubaseSoap11");
            client.ClientCredentials.UserName.UserName = username;
            client.ClientCredentials.UserName.Password = password;
            return client;
        }

    }
}
