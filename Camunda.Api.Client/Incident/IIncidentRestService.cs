using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Camunda.Api.Client.Incident
{
    internal interface IIncidentRestService
    {
        [Get("/incident")]
        Task<List<IncidentInfo>> GetList(QueryDictionary query, int? firstResult, int? maxResults);

        [Get("/incident/count")]
        Task<CountResult> GetListCount(QueryDictionary query);
    }
}
