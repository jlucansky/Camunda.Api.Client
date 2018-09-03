using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Camunda.Api.Client.History
{
    internal interface IHistoricCaseInstanceRestService
    {
        [Get("/history/case-instance/{id}")]
        Task<HistoricCaseInstance> Get(string id);

        [Post("/history/case-instance")]
        Task<List<HistoricCaseInstance>> GetList([Body]HistoricCaseInstanceQuery query, int? firstResult, int? maxResults);
    }
}