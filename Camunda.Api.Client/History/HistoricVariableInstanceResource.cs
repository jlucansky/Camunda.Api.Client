using System.Net.Http;
using System.Threading.Tasks;

namespace Camunda.Api.Client.History
{
    public class HistoricVariableInstanceResource
    {
        private IHistoricVariableInstanceRestService _api;
        private string _variableId;

        internal HistoricVariableInstanceResource(IHistoricVariableInstanceRestService api, string variableId)
        {
            _api = api;
            _variableId = variableId;
        }

        /// <summary>
        /// Retrieves a historic variable by id.
        /// </summary>
        public Task<HistoricVariableInstance> Get() => _api.Get(_variableId);

        /// <summary>
        /// Retrieves the content of a historic variable by id. Applicable for variables that are serialized as binary data.
        /// </summary>
        /// <returns></returns>
        public async Task<HttpContent> GetBinary() => (await _api.GetBinaryVariable(_variableId)).Content;
    }
}
