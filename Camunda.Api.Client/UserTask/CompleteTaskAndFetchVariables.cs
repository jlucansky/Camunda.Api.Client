namespace Camunda.Api.Client.UserTask
{
    public class CompleteTaskAndFetchVariables : CompleteTaskBase
    {
        /// <summary>
        /// Variables will return after completing the task
        /// </summary>
        protected override bool WithVariablesInReturn { get; } = true;
    }
}
