using System.Threading.Tasks;

namespace Camunda.Api.Client.History
{
    public class HistoricActivityInstanceResource
    {
        private IHistoricActivityInstanceRestService _api;
        private string _activityInstanceId;

        internal HistoricActivityInstanceResource(IHistoricActivityInstanceRestService api, string activityInstanceId)
        {
            _api = api;
            _activityInstanceId = activityInstanceId;
        }

        /// <summary>
        /// Retrieves a historic activity instance by id, according to the <see cref="HistoricActivityInstance"/> interface in the engine.
        /// </summary>
        public Task<HistoricActivityInstance> Get() => _api.Get(_activityInstanceId);
    }
}
