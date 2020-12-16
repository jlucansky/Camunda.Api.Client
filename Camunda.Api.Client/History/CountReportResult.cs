namespace Camunda.Api.Client.History
{
    public class CountReportResult
    {
        /// <summary>
        /// The task name of the task. It is only available when the groupBy-parameter is set to taskName. Else the value is null.
        /// </summary>
        public string TaskName;

        /// <summary>
        /// The id of the process definition
        /// </summary>
        public string ProcessDefinitionId;

        /// <summary>
        /// The key of the process definition.
        /// </summary>
        public string ProcessDefinitionKey;

        /// <summary>
        /// The name of the process definition.
        /// </summary>
        public string processDefinitionName;

        /// <summary>
        /// The number of tasks which have the given definition.
        /// </summary>
        public long Count;
    }
}
