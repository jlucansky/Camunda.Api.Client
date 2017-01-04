using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Camunda.Api.Client.History
{
    internal interface IHistoricActivityInstanceRestService
    {
        [Get("/history/activity-instance/{id}")]
        Task<HistoricActivityInstance> Get(string id);

        [Post("/history/activity-instance")]
        Task<List<HistoricActivityInstance>> GetList([Body] HistoricActivityInstanceQuery query, int? firstResult, int? maxResults);

        [Post("/history/activity-instance/count")]
        Task<CountResult> GetListCount([Body] HistoricActivityInstanceQuery query);
    }
}
