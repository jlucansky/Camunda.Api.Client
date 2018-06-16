using System;
using System.Collections.Generic;

namespace Camunda.Api.Client.History
{
    public class HistoricDetail
    {
        /// <summary>
        /// Type
        /// </summary>
        public string Type;
        /// <summary>
        /// The id of the entry.
        /// </summary>
        public string Id;
        /// <summary>
        /// The key of the process definition.
        /// </summary>
        public string ProcessDefinitionKey;
        /// <summary>
        /// The id of the process definition which the associated job belongs to.
        /// </summary>
        public string ProcessDefinitionId;
        /// <summary>
        /// The id of the process instance on which the associated job was created.
        /// </summary>
        public string ProcessInstanceId;
        /// <summary>
        /// The id of the activity instance that the external task belongs to.
        /// </summary>
        public string ActivityInstanceId;
        /// <summary>
        /// The execution id on which the associated job was created.
        /// </summary>
        public string ExecutionId;
        /// <summary>
        /// Case definition key
        /// </summary>
        public string CaseDefinitionKey;
        /// <summary>
        /// Case definition id
        /// </summary>
        public string CaseDefinitionId;
        /// <summary>
        /// Case instance id
        /// </summary>
        public string CaseInstanceId;
        /// <summary>
        /// Case execution id
        /// </summary>
        public string CaseExecutionId;
        /// <summary>
        /// Task id
        /// </summary>
        public string TaskId;
        /// <summary>
        /// The id of the tenant that this historic job log entry belongs to.
        /// </summary>
        public string TenantId;
        /// <summary>
        /// User operation id
        /// </summary>
        public string UserOperationId;
        /// <summary>
        /// Time
        /// </summary>
        public DateTime Time;
        /// <summary>
        /// Variable name
        /// </summary>
        public string VariableName;
        /// <summary>
        /// Variable instance id
        /// </summary>
        public string VariableInstanceId;
        /// <summary>
        /// Variable type
        /// </summary>
        public string VariableType;
        /// <summary>
        /// Value
        /// </summary>
        public object Value;
        /// <summary>
        /// Revision
        /// </summary>
        public string Revision;
        /// <summary>
        /// Error message
        /// </summary>
        public string ErrorMessage;
        /// <summary>
        /// Value info
        /// </summary>
        public Dictionary<string, object> ValueInfo;
        /// <summary>
        /// The id of the form field.
        /// </summary>
        public string FieldId;
        /// <summary>
        /// The submitted value.
        /// </summary>
        public object FieldValue;

        /// <summary>
        /// To string implementation
        /// </summary>
        /// <returns></returns>
        public override string ToString() => Id.ToString();
    }
}
