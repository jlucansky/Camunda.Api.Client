using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Camunda.Api.Client.Execution
{
    public class LocalVariableResource : IVariableResource
    {
        private string _executionId;
        private IExecutionRestService _api;

        internal LocalVariableResource(IExecutionRestService api, string executionId)
        {
            _api = api;
            _executionId = executionId;
        }

        /// <summary>
        /// Retrieves all variables of a given execution.
        /// </summary>
        public Task<Dictionary<string, VariableValue>> GetAll() => _api.GetLocalVariables(_executionId);
        /// <summary>
        /// Retrieves a variable from the context of a given execution. Does not traverse the parent execution hierarchy.
        /// </summary>
        public Task<VariableValue> Get(string variableName) => _api.GetLocalVariable(_executionId, variableName);
        /// <summary>
        /// Retrieves a binary variable from the context of a given execution. Does not traverse the parent execution hierarchy. Applicable for byte array and file variables.
        /// </summary>
        public async Task<HttpContent> GetBinary(string variableName) => (await _api.GetBinaryLocalVariable(_executionId, variableName)).Content;
        /// <summary>
        /// Sets a variable in the context of a given execution. Update does not propagate upwards in the execution hierarchy.
        /// </summary>
        public Task Set(string variableName, VariableValue variable) => _api.PutLocalVariable(_executionId, variableName, variable);
        /// <summary>
        /// Sets the serialized value for a binary variable or the binary value for a file variable.
        /// </summary>
        public Task SetBinary(string variableName, BinaryDataContent data, BinaryVariableType valueType) => _api.SetBinaryLocalVariable(_executionId, variableName, data, new ValueTypeContent(valueType.ToString()));
        /// <summary>
        /// Deletes a variable in the context of a given execution. Deletion does not propagate upwards in the execution hierarchy.
        /// </summary>
        public Task Delete(string variableName) => _api.DeleteLocalVariable(_executionId, variableName);
        /// <summary>
        /// Updates or deletes the variables in the context of an execution. The updates do not propagate upwards in the execution hierarchy. Updates precede deletions. So, if a variable is updated AND deleted, the deletion overrides the update.
        /// </summary>
        public Task Modify(PatchVariables patch) => _api.ModifyLocalVariables(_executionId, patch);

        public override string ToString() => _executionId;
    }
}
