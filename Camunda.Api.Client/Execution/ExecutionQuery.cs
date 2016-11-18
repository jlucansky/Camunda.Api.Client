using Newtonsoft.Json;
using System.Collections.Generic;

namespace Camunda.Api.Client.Execution
{
    public class ExecutionQuery : SortableQuery<ExecutionSorting, ExecutionQuery>
    {
        /// <summary>
        /// Filter by the key of the process definition the executions run on.
        /// </summary>
        public string ProcessDefinitionKey;
        /// <summary>
        /// Filter by the business key of the process instances the executions belong to.
        /// </summary>
        public string BusinessKey;
        /// <summary>
        /// Filter by the process definition the executions run on.
        /// </summary>
        public string ProcessDefinitionId;
        /// <summary>
        /// Filter by the id of the process instance the execution belongs to.
        /// </summary>
        public string ProcessInstanceId;
        /// <summary>
        /// Filter by the id of the activity the execution currently executes.
        /// </summary>
        public string ActivityId;
        /// <summary>
        /// Select only those executions that expect a signal of the given name.
        /// </summary>
        public string SignalEventSubscriptionName;
        /// <summary>
        /// Select only those executions that expect a message of the given name.
        /// </summary>
        public string MessageEventSubscriptionName;
        /// <summary>
        /// Only include active executions. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool Active;
        /// <summary>
        /// Only include suspended executions. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool Suspended;
        /// <summary>
        /// Filter by the incident id.
        /// </summary>
        public string IncidentId;
        /// <summary>
        /// Filter by the incident type.
        /// </summary>
        public string IncidentType;
        /// <summary>
        /// Filter by the incident message. Exact match.
        /// </summary>
        public string IncidentMessage;
        /// <summary>
        /// Filter by the incident message that the parameter is a substring of.
        /// </summary>
        public string IncidentMessageLike;
        /// <summary>
        /// Filter by a list of tenant ids. An execution must have one of the given tenant ids.
        /// </summary>
        [JsonProperty("tenantIdIn")]
        public List<string> TenantIds;

        /// <summary>
        /// Array to only include executions that have variables with certain values. 
        /// The array consists of objects with the three properties key, operator and value.key(String) is the variable name, operator (String) is the comparison operator to be used and value the variable value.
        /// Value may be String, Number or Boolean.
        /// </summary>
        public List<VariableQueryParameter> Variables = new List<VariableQueryParameter>();

        /// <summary>
        /// Array to only include executions that belong to a process instance with variables with certain values. 
        /// A valid parameter value has the form key_operator_value.key is the variable name, operator is the comparison operator to be used and value the variable value.
        /// </summary>
        /// <remarks>Values are always treated as String objects on server side.</remarks>
        public List<VariableQueryParameter> ProcessVariables = new List<VariableQueryParameter>();
    }

    public enum ExecutionSorting
    {
        InstanceId,
        DefinitionKey,
        DefinitionId,
        TenantId
    }
}
