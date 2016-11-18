using System.Net.Http;
using System.Threading.Tasks;

namespace Camunda.Api.Client.VariableInstance
{
    public class VariableInstanceResource
    {
        private string _variableInstanceId;
        private IVariableInstanceRestService _api;

        internal VariableInstanceResource(IVariableInstanceRestService api, string variableInstanceId)
        {
            _api = api;
            _variableInstanceId = variableInstanceId;
        }

        /// <summary>
        /// Retrieves a single variable by id.
        /// </summary>
        public Task<VariableInstanceInfo> Get() => _api.Get(_variableInstanceId);
        
        /// <summary>
        /// Retrieves the content of a single variable by id.
        /// Applicable for byte array and file variables.
        /// </summary>
        public async Task<HttpContent> GetBinary() => (await _api.GetBinaryVariable(_variableInstanceId)).Content;

        public override string ToString() => _variableInstanceId;
    }
}
