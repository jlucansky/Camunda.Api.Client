
using System.Collections.Generic;

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

        /// <summary>
        /// An error message that describes the error.
        /// </summary>
        public string ErrorMessage;

        /// <summary>
        /// Object containing variable key-value pairs.
        /// </summary>
        public Dictionary<string, VariableValue> Variables = new Dictionary<string, VariableValue>();


        public override string ToString() => ErrorCode;
    }
}
