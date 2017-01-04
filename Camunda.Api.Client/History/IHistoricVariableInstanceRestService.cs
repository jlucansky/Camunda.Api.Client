using Refit;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Camunda.Api.Client.History
{
    internal interface IHistoricVariableInstanceRestService
    {
        [Get("/history/variable-instance/{id}")]
        Task<HistoricVariableInstance> Get(string id, bool deserializeValue = true);

        [Post("/history/variable-instance")]
        Task<List<HistoricVariableInstance>> GetList([Body] HistoricVariableInstanceQuery query, int? firstResult, int? maxResults, bool deserializeValues = true);

        [Post("/history/variable-instance/count")]
        Task<CountResult> GetListCount([Body] HistoricVariableInstanceQuery query);

        [Get("/history/variable-instance/{id}/data")]
        Task<HttpResponseMessage> GetBinaryVariable(string id);
    }
}
