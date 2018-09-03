using System.Collections.Generic;

namespace Camunda.Api.Client.CaseDefinition
{
    public class CreateCaseInstance
    {
        /// <summary>
        /// Object containing the variables the case is to be initialized with. Each key corresponds to a variable name and each value to a variable value.
        /// </summary>
        public Dictionary<string, VariableValue> Variables = new Dictionary<string, VariableValue>();

        /// <summary>
        /// The business key the case instance is to be initialized with. The business key uniquely identifies the case instance in the context of the given case definition.
        /// </summary>
        public string BusinessKey;

        public CreateCaseInstance SetVariable(string name, object value)
        {
            Variables = (Variables ?? new Dictionary<string, VariableValue>()).Set(name, value);
            return this;
        }
    }
}