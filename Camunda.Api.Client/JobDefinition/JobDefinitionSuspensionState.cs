using System;

namespace Camunda.Api.Client.JobDefinition
{
    public class JobDefinitionSuspensionState : SuspensionState
    {
        /// <summary>
        /// The date on which the given job definition will be activated or suspended. If <c>null</c>, the suspension state of the given job definition is updated immediately
        /// </summary>
        public DateTime? ExecutionDate;
        /// <summary>
        /// A Boolean value which indicates whether to activate or suspend also all jobs of the given job definition.
        /// When the value is set to true, all jobs of the provided job definition will be activated or suspended and when the value is set to false, the suspension state of all jobs of the provided job definition will not be updated.
        /// </summary>
        public bool IncludeJobs;
        /// <summary>
        /// The process definition id of the job definitions to activate or suspend.
        /// </summary>
        public string ProcessDefinitionId;
        /// <summary>
        /// The process definition key of the job definitions to activate or suspend.
        /// </summary>
        public string ProcessDefinitionKey;
        /// <summary>
        /// Only activate or suspend job definitions of a process definition which belongs to a tenant with the given id.
        /// </summary>
        public string ProcessDefinitionTenantId;
        /// <summary>
        /// Only activate or suspend job definitions of a process definition which belongs to no tenant.
        /// </summary>
        public bool ProcessDefinitionWithoutTenantId;
    }
}