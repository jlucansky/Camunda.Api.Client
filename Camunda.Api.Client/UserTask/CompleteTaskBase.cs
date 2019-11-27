using System;
using System.Collections.Generic;
using System.Text;

namespace Camunda.Api.Client.UserTask
{
    public abstract class CompleteTaskBase
    {
        /// <summary>
        /// Variables will return after completing the task
        /// </summary>
        public abstract bool WithVariablesInReturn { get; }

        /// <summary>
        /// Object containing variable key-value pairs.
        /// </summary>
        public Dictionary<string, VariableValue> Variables = new Dictionary<string, VariableValue>();

        public CompleteTaskBase SetVariable(string name, object value)
        {
          Variables = (Variables ?? new Dictionary<string, VariableValue>()).Set(name, value);
          return this;
        }
    }
}
