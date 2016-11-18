using Refit;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Camunda.Api.Client.VariableInstance
{
    internal interface IVariableInstanceRestService
    {
        [Get("/variable-instance/{variableInstanceId}")]
        Task<VariableInstanceInfo> Get(string variableInstanceId);

        [Post("/variable-instance")]
        Task<List<VariableInstanceInfo>> GetList([Body] VariableInstanceQuery query, int? firstResult, int? maxResults, bool deserializeValues = true);

        [Post("/variable-instance/count")]
        Task<CountResult> GetListCount([Body] VariableInstanceQuery query);

        [Get("/variable-instance/{variableInstanceId}/data")]
        Task<HttpResponseMessage> GetBinaryVariable(string variableInstanceId);
    }
}
