using System.Threading.Tasks;

namespace Camunda.Api.Client.Message
{
    public class MessageService
    {
        private IMessageRestService _api;

        internal MessageService(IMessageRestService api)
        {
            _api = api;
        }

        /// <summary>
        /// Deliver a message to the process engine to either trigger a message start event or an intermediate message catching event. 
        /// Internally this maps to the engine’s message correlation builder methods <c>MessageCorrelationBuilder#correlate()</c> and <c>MessageCorrelationBuilder#correlateAll()</c>
        /// </summary>
        public Task DeliverMessage(CorrelationMessage message) => _api.DeliverMessage(message);
    }
}
