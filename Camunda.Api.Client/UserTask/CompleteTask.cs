using System.Collections.Generic;

namespace Camunda.Api.Client.UserTask
{
    public class CompleteTask
    {
        /// <summary>
        /// Object containing variable key-value pairs.
        /// </summary>
        public Dictionary<string, VariableValue> Variables = new Dictionary<string, VariableValue>();

        public CompleteTask SetVariable(string name, object value)
        {
            Variables = (Variables ?? new Dictionary<string, VariableValue>()).Set(name, value);
            return this;
        }
    }
}
