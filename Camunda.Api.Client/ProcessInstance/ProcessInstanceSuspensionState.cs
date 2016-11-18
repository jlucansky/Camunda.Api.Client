namespace Camunda.Api.Client.ProcessInstance
{
    public class ProcessInstanceSuspensionState : SuspensionState
    {
        /// <summary>
        /// The process definition id of the process instances to activate or suspend.
        /// </summary>
        public string ProcessDefinitionId;
        /// <summary>
        /// The process definition key of the process instances to activate or suspend.
        /// </summary>
        public string ProcessDefinitionKey;
        /// <summary>
        /// Only activate or suspend process instances of a process definition which belongs to a tenant with the given id.
        /// </summary>
        public string ProcessDefinitionTenantId;
        /// <summary>
        /// Only activate or suspend process instances of a process definition which belongs to no tenant. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool ProcessDefinitionWithoutTenantId;
    }
}
