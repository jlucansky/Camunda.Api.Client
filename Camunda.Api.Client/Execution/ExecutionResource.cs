using System.Threading.Tasks;

namespace Camunda.Api.Client.Execution
{
    public class ExecutionResource
    {
        private IExecutionRestService _api;
        private string _executionId;

        internal ExecutionResource(IExecutionRestService api, string executionId)
        {
            _api = api;
            _executionId = executionId;
        }

        public LocalVariableResource LocalVariables => new LocalVariableResource(_api, _executionId);

        /// <summary>
        /// Retrieves a single execution according to the Execution interface in the engine.
        /// </summary>
        public Task<ExecutionInfo> Get() => _api.Get(_executionId);
        /// <summary>
        /// Signals a single execution. Can for example be used to explicitly skip user tasks or signal asynchronous continuations.
        /// </summary>
        public Task Trigger(ExecutionTrigger trigger) => _api.TriggerExecution(_executionId, trigger);

        public EventSubscriptionResource GetMessageEventSubscription(string messageName) => new EventSubscriptionResource(_api, _executionId, messageName);

        public override string ToString() => _executionId;
    }
}
