namespace Camunda.Api.Client.History
{
    public class HistoricUserOperationLogQuery : SortableQuery<HistoricUserOperationLogSorting, HistoricUserOperationLogQuery>
    {
        /// <summary>
        /// Filter by the process definition the instances run on.
        /// </summary>
        public string ProcessDefinitionId;
        /// <summary>
        /// Filter by the process definition the instances run on.
        /// </summary>
        public string ProcessInstanceId;
        /// <summary>
        /// Filter by the task the instances run on.
        /// </summary>
        public string TaskId;
        /// <summary>
        /// Filter by the property.
        /// </summary>
        public string Property;
        /// <summary>
        /// Filter by the OperationType.
        /// </summary>
        public string OperationType;
        /// <summary>
        /// Sort the results by a given criterion. At the moment the query only supports sorting based on the timestamp.
        /// </summary>
        public HistoricUserOperationLogSorting SortBy;
        /// <summary>
        /// Sort the results in a given order. Must be used in conjunction with the <see cref="SortBy"/> parameter.
        /// </summary>
        public SortOrder SortOrder;
    }

    public enum HistoricUserOperationLogSorting
    {
        ProcessInstanceId,
        TaskId,
        Timestamp
    }
}
