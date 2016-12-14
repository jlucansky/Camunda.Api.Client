using Camunda.Api.Client.Execution;
using Camunda.Api.Client.ProcessInstance;
using System.Runtime.Serialization;

namespace Camunda.Api.Client.Message
{
    public class CorrelationResult
    {
        /// <summary>
        /// Indicates if the message was correlated to a message start event or an intermediate message catching event.
        /// In the first case, the <see cref="ResultType"/> is <see cref="MessageCorrelationResultType.ProcessDefinition"/> and otherwise <see cref="MessageCorrelationResultType.Execution"/>.
        /// </summary>
        public MessageCorrelationResultType ResultType;

        /// <summary>
        /// This property only has a value if the <see cref="ResultType"/> is set to <see cref="MessageCorrelationResultType.Execution"/>.
        /// </summary>
        public ExecutionInfo Execution;

        /// <summary>
        /// This property only has a value if the <see cref="ResultType"/> is set to <see cref="MessageCorrelationResultType.ProcessDefinition"/>
        /// </summary>
        public ProcessInstanceInfo ProcessInstance;
    }

    public enum MessageCorrelationResultType
    {
        [EnumMember(Value = nameof(ProcessDefinition))]
        ProcessDefinition,

        [EnumMember(Value = nameof(Execution))]
        Execution,
    }
}
