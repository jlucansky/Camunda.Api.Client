#region Usings

using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

#endregion

namespace Camunda.Api.Client.CaseInstance
{
    public class CaseInstanceResource
    {
        private string _caseInstanceId;
        private ICaseInstanceRestService _api;

        internal CaseInstanceResource(ICaseInstanceRestService api, string caseInstanceId)
        {
            _api = api;
            _caseInstanceId = caseInstanceId;
        }

        /// <summary>
        /// Retrieves a case instance by id, according to the CaseInstance interface in the engine.
        /// </summary>
        /// <returns>corresponding case instance basis info</returns>
        public Task<CaseInstanceInfo> Get() => _api.Get(_caseInstanceId);

        /// <summary>
        /// Retrieves all variables of a given case instance by id.
        /// </summary>
        /// <param name="deserializeValues">Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on server side (default true). Note: While true is the default value for reasons of backward compatibility, we recommend setting this parameter to false when developing web applications that are independent of the Java process applications deployed to the engine.</param>
        /// <returns>variables key-value pairs. Each key is a variable name and each value a variable value object</returns>
        public Task<Dictionary<string, VariableValue>> GetVariables(bool? deserializeValues) =>
            _api.GetVariables(_caseInstanceId, deserializeValues);

        /// <summary>
        /// Retrieves a variable of a given case instance by id.
        /// </summary>
        /// <param name="varName">The name of the variable to get.</param>
        /// <param name="deserializeValue">Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on server side (default true). Note: While true is the default value for reasons of backward compatibility, we recommend setting this parameter to false when developing web applications that are independent of the Java process applications deployed to the engine.</param>
        /// <returns>corresponding variable value object</returns>
        public Task<VariableValue> GetVariableValue(string varName, bool? deserializeValue) =>
            _api.GetVariableValue(_caseInstanceId, varName, deserializeValue);

        /// <summary>
        /// Retrieves a binary variable of a given case instance by id. Applicable for byte array and file variables.
        /// </summary>
        /// <param name="varName">The name of the variable to get.</param>
        /// <returns></returns>
        public Task<HttpResponseMessage> GetVariableValueBinary(string varName) =>
            _api.GetVariableValueBinary(_caseInstanceId, varName);

        /// <summary>
        /// Updates or deletes the variables of a case instance. Please note: deletion precedes update.
        /// </summary>
        /// <param name="modifications">an object containing deletions and updates</param>
        /// <returns></returns>
        public Task ModifyVariables(CaseInstanceModifications modifications) =>
            _api.ModifyVariables(_caseInstanceId, modifications);

        /// <summary>
        /// Sets a variable of a given case instance by id.
        /// </summary>
        /// <param name="varName">The name of the variable to set.</param>
        /// <param name="value">variable value object</param>
        /// <returns></returns>
        public Task UpdateVariable(string varName, VariableValue value) =>
            _api.UpdateVariable(_caseInstanceId, varName, value);

        /// <summary>
        /// Deletes a variable of a given case instance by id.
        /// </summary>
        /// <param name="varName">The name of the variable to delete.</param>
        /// <returns></returns>
        public Task DeleteVariable(string varName) => _api.DeleteVariable(_caseInstanceId, varName);

        /// <summary>
        /// Sets the serialized value for a binary variable or the binary value for a file variable.
        /// </summary>
        /// <param name="varName">The name of the variable to set.</param>
        /// <param name="value"></param>
        /// <returns></returns>
        public Task SetVariableBinary(string varName, CaseInstanceBinaryVariableValue value) =>
            _api.SetVariableBinary(_caseInstanceId, varName, value);

        /// <summary>
        /// Performs a transition from ACTIVE state to COMPLETED state. In relation to the state transition, it is possible to update or delete case instance variables (please note: deletion precedes update).
        /// </summary>
        /// <param name="completeCaseInstanceState">contains variables to delete or update</param>
        /// <returns></returns>
        public Task Complete(ChangeCaseInstanceState completeCaseInstanceState) =>
            _api.Complete(_caseInstanceId, completeCaseInstanceState);

        /// <summary>
        /// Performs a transition from COMPLETED state to CLOSED state. In relation to the state transition, it is possible to update or delete case instance variables (please note: deletion precedes update).
        /// </summary>
        /// <param name="closeCaseInstanceState">contains variables to delete or update</param>
        /// <returns></returns>
        public Task Close(ChangeCaseInstanceState closeCaseInstanceState) =>
            _api.Close(_caseInstanceId, closeCaseInstanceState);

        /// <summary>
        /// Performs a transition from ACTIVE state to TERMINATED state. In relation to the state transition, it is possible to update or delete case instance variables (please note: deletion precedes update).
        /// </summary>
        /// <param name="terminateCaseInstanceState">contains variables to delete or update</param>
        /// <returns></returns>
        public Task Terminate(ChangeCaseInstanceState terminateCaseInstanceState) =>
            _api.Terminate(_caseInstanceId, terminateCaseInstanceState);
    }
}
