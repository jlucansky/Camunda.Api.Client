using Camunda.Api.Client.ProcessInstance;
using System.Collections.Generic;

namespace Camunda.Api.Client.ProcessDefinition
{
    public class SubmitStartForm
    {
        /// <summary>
        /// Object containing the variables the process is to be initialized with. Each key corresponds to a variable name and each value to a variable value.
        /// </summary>
        public Dictionary<string, VariableValue> Variables = new Dictionary<string, VariableValue>();

        /// <summary>
        /// The business key the process instance is to be initialized with. The business key uniquely identifies the process instance in the context of the given process definition.
        /// </summary>
        public string BusinessKey;

        public SubmitStartForm SetVariable(string name, object value)
        {
            Variables = (Variables ?? new Dictionary<string, VariableValue>()).Set(name, value);
            return this;
        }
    }
}
