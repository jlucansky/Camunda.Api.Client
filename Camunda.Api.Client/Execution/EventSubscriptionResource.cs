using System.Threading.Tasks;

namespace Camunda.Api.Client.Execution
{
    public class EventSubscriptionResource
    {
        private string _executionId;
        private IExecutionRestService _api;
        private string _messageName;

        internal EventSubscriptionResource(IExecutionRestService api, string executionId, string messageName)
        {
            _api = api;
            _executionId = executionId;
            _messageName = messageName;
        }

        /// <summary>
        /// Get a message event subscription for a specific execution and a message name.
        /// </summary>
        public Task<EventSubscription> Get() => _api.GetMessageEventSubscription(_executionId, _messageName);

        /// <summary>
        /// Deliver a message to a specific execution to trigger an existing message event subscription. Inject process variables as the message’s payload.
        /// </summary>
        public Task Trigger(ExecutionTrigger trigger) => _api.TriggerMessageEventSubscription(_executionId, _messageName, trigger);

        public override string ToString() => _executionId;
    }
}
