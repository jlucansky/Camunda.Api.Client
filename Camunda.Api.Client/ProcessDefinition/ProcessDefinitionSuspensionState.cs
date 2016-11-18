using Camunda.Api.Client.ProcessInstance;
using System;

namespace Camunda.Api.Client.ProcessDefinition
{
    public class ProcessDefinitionSuspensionState : SuspensionState
    {
        /// <summary>
        /// The date on which the given process definition will be activated or suspended. If null, the suspension state of the given process definition is updated immediately.
        /// </summary>
        public DateTime? ExecutionDate;
        /// <summary>
        /// A Boolean value which indicates whether to activate or suspend also all process instances of the given process definition. 
        /// When the value is set to true, all process instances of the provided process definition will be activated or suspended and when the value is set to false, 
        /// the suspension state of all process instances of the provided process definition will not be updated.
        /// </summary>
        public bool IncludeProcessInstances;
    }
}
