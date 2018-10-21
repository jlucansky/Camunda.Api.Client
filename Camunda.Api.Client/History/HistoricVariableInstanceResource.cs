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
        /// <param name="deserializeValue">Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on server side.</param>
        public Task<HistoricVariableInstance> Get(bool deserializeValue = true) => _api.Get(_variableId, deserializeValue);

        /// <summary>
        /// Retrieves the content of a historic variable by id. Applicable for variables that are serialized as binary data.
        /// </summary>
        /// <returns></returns>
        public async Task<HttpContent> GetBinary() => (await _api.GetBinaryVariable(_variableId)).Content;
    }
}
