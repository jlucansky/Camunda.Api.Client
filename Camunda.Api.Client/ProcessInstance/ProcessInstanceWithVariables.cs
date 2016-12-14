using System.Collections.Generic;

namespace Camunda.Api.Client.ProcessInstance
{
    public class ProcessInstanceWithVariables : ProcessInstanceInfo
    {
        /// <summary>
        /// Object containing a property for each of the latest variables.
        /// </summary>
        public Dictionary<string, VariableValue> Variables;
    }
}
