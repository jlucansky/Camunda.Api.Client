using System.Threading.Tasks;

namespace Camunda.Api.Client.Signal
{
    public class SignalService
    {
        private ISignalRestService _api;

        internal SignalService(ISignalRestService api)
        {
            _api = api;
        }

        /// <summary>
        /// A signal is an event of global scope (broadcast semantics) and is delivered to all active handlers.
        /// Internally this maps to the engine’s signal event received builder method RuntimeService#createSignalEvent().
        /// </summary>
        public Task ThrowSignal(Signal signal) => _api.ThrowSignal(signal);
    }
}