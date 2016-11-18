using System;
using System.Collections.Generic;

namespace Camunda.Api.Client.ExternalTask
{
    public class LockedExternalTask : ExternalTaskInfo
    {
        /// <summary>
        /// Object containing a property for each of the requested variables.
        /// </summary>
        public Dictionary<string, VariableValue> Variables;
    }
}
