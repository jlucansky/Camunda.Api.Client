using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Camunda.Api.Client.ProcessInstance
{
    public class VariableResource : IVariableResource
    {
        private string _processInstanceId;
        private IProcessInstanceRestService _api;

        internal VariableResource(IProcessInstanceRestService api, string processInstanceId)
        {
            _api = api;
            _processInstanceId = processInstanceId;
        }

        /// <summary>
        /// Retrieves all variables of a given process instance.
        /// </summary>
        /// <param name="deserializeValues">Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on server side.</param>
        public Task<Dictionary<string, VariableValue>> GetAll(bool deserializeValues = true) => _api.GetVariables(_processInstanceId, deserializeValues);

        /// <summary>
        /// Retrieves a variable of a given process instance.
        /// </summary>
        /// <param name="variableName">The name of the variable to get.</param>
        /// <param name="deserializeValue">Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on server side.</param>
        public Task<VariableValue> Get(string variableName, bool deserializeValue = true) => _api.GetVariable(_processInstanceId, variableName, deserializeValue);

        /// <summary>
        /// Retrieves the serialized value for a binary variable or the binary value for a file variable.
        /// </summary>
        /// <param name="variableName">The name of the variable to get.</param>
        public async Task<HttpContent> GetBinary(string variableName) => (await _api.GetBinaryVariable(_processInstanceId, variableName)).Content;

        /// <summary>
        /// Sets a variable of a given process instance.
        /// </summary>
        /// <param name="variableName">The name of the variable to set.</param>
        /// <param name="variable"></param>
        public Task Set(string variableName, VariableValue variable) => _api.PutVariable(_processInstanceId, variableName, variable);

        /// <summary>
        /// Sets the serialized value for a binary variable or the binary value for a file variable.
        /// </summary>
        /// <param name="variableName">The name of the variable to set.</param>
        /// <param name="data">The binary data to be set.</param>
        /// <param name="valueType">The name of the variable type. Either Bytes for a byte array variable or File for a file variable.</param>
        public Task SetBinary(string variableName, BinaryDataContent data, BinaryVariableType valueType) => _api.SetBinaryVariable(_processInstanceId, variableName, data, new ValueTypeContent(valueType.ToString()));

        /// <summary>
        /// Deletes a variable of a given process instance.
        /// </summary>
        /// <param name="variableName">The name of the variable to delete.</param>
        public Task Delete(string variableName) => _api.DeleteVariable(_processInstanceId, variableName);

        /// <summary>
        /// Updates or deletes the variables of a process instance. Updates precede deletions. So, if a variable is updated AND deleted, the deletion overrides the update.
        /// </summary>
        public Task Modify(PatchVariables patch) => _api.ModifyVariables(_processInstanceId, patch);

        public override string ToString() => _processInstanceId;
    }
}
