using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Camunda.Api.Client.CaseInstance
{
    public class VariableResource : IVariableResource
    {
        private string _caseInstanceId;
        private ICaseInstanceRestService _api;

        internal VariableResource(ICaseInstanceRestService api, string caseInstanceId)
        {
            _api = api;
            _caseInstanceId = caseInstanceId;
        }

        /// <summary>
        /// Retrieves all variables of a given case instance.
        /// </summary>
        /// <param name="deserializeValues">Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on server side.</param>
        public Task<Dictionary<string, VariableValue>> GetAll(bool deserializeValues = true) => _api.GetVariables(_caseInstanceId, deserializeValues);
        /// <summary>
        /// Retrieves a variable from the context of a given case instance.
        /// </summary>
        public Task<VariableValue> Get(string variableName, bool deserializeValue = true) => _api.GetVariableValue(_caseInstanceId, variableName, deserializeValue);
        /// <summary>
        /// Retrieves a binary variable from the context of a given case instance. Applicable for byte array and file variables.
        /// </summary>
        public async Task<HttpContent> GetBinary(string variableName) => (await _api.GetBinaryVariable(_caseInstanceId, variableName)).Content;
        /// <summary>
        /// Sets a variable in the context of a given case instance.
        /// </summary>
        public Task Set(string variableName, VariableValue variable) => _api.UpdateVariable(_caseInstanceId, variableName, variable);
        /// <summary>
        /// Sets the serialized value for a binary variable or the binary value for a file variable.
        /// </summary>
        public Task SetBinary(string variableName, BinaryDataContent data, BinaryVariableType valueType) => _api.SetBinaryVariable(_caseInstanceId, variableName, data, new ValueTypeContent(valueType.ToString()));
        /// <summary>
        /// Removes a variable from a case instance.
        /// </summary>
        public Task Delete(string variableName) => _api.DeleteVariable(_caseInstanceId, variableName);
        /// <summary>
        /// Updates or deletes the variables in the context of a case instance. Updates precede deletions. So, if a variable is updated AND deleted, the deletion overrides the update.
        /// </summary>
        public Task Modify(PatchVariables patch) => _api.ModifyVariables(_caseInstanceId, patch);

        public override string ToString() => _caseInstanceId;
    }
}
