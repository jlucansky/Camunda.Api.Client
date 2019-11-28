namespace Camunda.Api.Client.UserTask
{
    public class CompleteTask : CompleteTaskBase
    {
        /// <summary>
        /// Variables will return after completing the task
        /// </summary>
        public override bool WithVariablesInReturn => false;
    }
}
