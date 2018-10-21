using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Camunda.Api.Client.UserTask
{
    public class LocalVariableResource : IVariableResource
    {
        private string _taskId;
        private IUserTaskRestService _api;

        internal LocalVariableResource(IUserTaskRestService api, string taskId)
        {
            _api = api;
            _taskId = taskId;
        }

        /// <summary>
        /// Retrieves all variables of a given task.
        /// </summary>
        /// <param name="deserializeValues">Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on server side.</param>
        public Task<Dictionary<string, VariableValue>> GetAll(bool deserializeValues = true) => _api.GetLocalVariables(_taskId, deserializeValues);
        /// <summary>
        /// Retrieves a variable from the context of a given task.
        /// </summary>
        public Task<VariableValue> Get(string variableName, bool deserializeValue = true) => _api.GetLocalVariable(_taskId, variableName, deserializeValue);
        /// <summary>
        /// Retrieves a binary variable from the context of a given task. Applicable for byte array and file variables.
        /// </summary>
        public async Task<HttpContent> GetBinary(string variableName) => (await _api.GetBinaryLocalVariable(_taskId, variableName)).Content;
        /// <summary>
        /// Sets a variable in the context of a given task.
        /// </summary>
        public Task Set(string variableName, VariableValue variable) => _api.PutLocalVariable(_taskId, variableName, variable);
        /// <summary>
        /// Sets the serialized value for a binary variable or the binary value for a file variable.
        /// </summary>
        public Task SetBinary(string variableName, BinaryDataContent data, BinaryVariableType valueType) => _api.SetBinaryLocalVariable(_taskId, variableName, data, new ValueTypeContent(valueType.ToString()));
        /// <summary>
        /// Removes a variable from a task.
        /// </summary>
        public Task Delete(string variableName) => _api.DeleteLocalVariable(_taskId, variableName);
        /// <summary>
        /// Updates or deletes the variables in the context of a task. Updates precede deletions. So, if a variable is updated AND deleted, the deletion overrides the update.
        /// </summary>
        public Task Modify(PatchVariables patch) => _api.ModifyLocalVariables(_taskId, patch);

        public override string ToString() => _taskId;
    }
}
