using System.Collections.Generic;

namespace Camunda.Api.Client.ExternalTask
{
    public class LockedExternalTask : ExternalTaskInfo
    {
        /// <summary>
        /// Object containing a property for each of the requested variables.
        /// </summary>
        public Dictionary<string, VariableValue> Variables;

        /// <summary>
        /// Object containing all extended properties from the BPMN for this task.
        /// </summary>
        public Dictionary<string, string> ExtensionProperties;
    }
}
