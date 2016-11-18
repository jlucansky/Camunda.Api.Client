using System.Collections.Generic;

namespace Camunda.Api.Client.ExternalTask
{
    public class CompleteExternalTask
    {
        /// <summary>
        /// The id of the worker that completes the task. Must match the id of the worker who has most recently locked the task.
        /// </summary>
        public string WorkerId;

        /// <summary>
        /// Dictionary containing variable key-value pairs.
        /// </summary>
        public Dictionary<string, VariableValue> Variables;

        public CompleteExternalTask SetVariable(string name, object value)
        {
            Variables = (Variables ?? new Dictionary<string, VariableValue>()).Set(name, value);
            return this;
        }
    }

}