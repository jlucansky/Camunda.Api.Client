
namespace Camunda.Api.Client.ExternalTask
{
    public class ExternalTaskBpmnError
    {
        /// <summary>
        /// The id of the worker that reports the failure. Must match the id of the worker who has most recently locked the task.
        /// </summary>
        public string WorkerId;

        /// <summary>
        /// A error code that indicates the predefined error. Is used to identify the BPMN error handler.
        /// </summary>
        public string ErrorCode;

        public override string ToString() => ErrorCode;
    }
}
