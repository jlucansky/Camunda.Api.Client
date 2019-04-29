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

        /// <summary>
        /// Dictionary containing variable key-value pairs. Local variables are set only in the scope of external task.
        /// </summary>
        public Dictionary<string, VariableValue> LocalVariables;

        public CompleteExternalTask SetVariable(string name, object value)
        {
            Variables = (Variables ?? new Dictionary<string, VariableValue>()).Set(name, value);
            return this;
        }

        /// <summary>
        /// Local variables are set only in the scope of external task.
        /// </summary>
        public CompleteExternalTask SetLocalVariable(string name, object value)
        {
            LocalVariables = (LocalVariables ?? new Dictionary<string, VariableValue>()).Set(name, value);
            return this;
        }
    }
}