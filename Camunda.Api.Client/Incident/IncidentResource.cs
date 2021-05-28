using System.Threading.Tasks;

namespace Camunda.Api.Client.Incident
{
    public class IncidentResource
    {
        private IIncidentRestService _api;
        private string _incidentId;

        internal IncidentResource(IIncidentRestService api, string incidentId)
        {
            _api = api;
            _incidentId = incidentId;
        }

        /// <summary>
        /// Retrieves an incident by ID
        /// </summary>
        /// <returns></returns>
        public Task<IncidentInfo> Get() => _api.Get(_incidentId);

        /// <summary>
        /// Resolves an incident with given id
        /// </summary>
        /// <returns></returns>
        public Task Resolve() => _api.Resolve(_incidentId);

        public override string ToString() => _incidentId;
    }
}
