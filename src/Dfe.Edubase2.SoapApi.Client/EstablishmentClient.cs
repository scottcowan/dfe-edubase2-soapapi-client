using System.Collections.Generic;
using System.Threading.Tasks;
using Dfe.Edubase2.SoapApi.Client.EdubaseService;

namespace Dfe.Edubase2.SoapApi.Client
{
    public class EstablishmentClient
    {
        private readonly EdubaseClient _client;

        public EstablishmentClient(string username, string password)
        {
            _client = CreateEdubaseClient(username, password);
        }

        public IEnumerable<Establishment> FindEstablishments(EstablishmentFilter filter = null)
        {
            int pages;
            filter = filter ?? new EstablishmentFilter();
            foreach (var establishment in _client.FindEstablishments(filter, out pages))
            {
                yield return establishment;
            }

            for (var i = 1; i < pages; i++)
            {
                filter.Page = i;
                foreach (var establishment in _client.FindEstablishments(filter, out pages))
                {
                    yield return establishment;
                }
            }
        }

        public async Task<List<Establishment>> FindEstablishmentsAsync(EstablishmentFilter filter = null)
        {
            var list = new List<Establishment>();
            filter = filter ?? new EstablishmentFilter();
            var response = await _client.FindEstablishmentsAsync(new FindEstablishmentsRequest(filter));
            list.AddRange(response.Establishments);
            for (var i = 1; i < response.PageCount; i++)
            {
                filter.Page = i;
                list.AddRange((await _client.FindEstablishmentsAsync(new FindEstablishmentsRequest(filter))).Establishments);
            }

            return list;
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
