using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Camunda.Api.Client.History
{
    internal interface IHistoricIncidentRestService
    {
        [Get("/history/incident")]
        Task<List<HistoricIncident>> GetList(HistoricIncidentQuery query, int? firstResult, int? maxResults);

        [Get("/history/incident/count")]
        Task<CountResult> GetListCount(HistoricIncidentQuery query);
    }
}
