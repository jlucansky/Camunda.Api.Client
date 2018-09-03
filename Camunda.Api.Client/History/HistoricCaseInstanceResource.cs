using System.Threading.Tasks;

namespace Camunda.Api.Client.History
{
    public class HistoricCaseInstanceResource
    {
        private IHistoricCaseInstanceRestService _api;
        private string _caseInstanceId;

        internal HistoricCaseInstanceResource(IHistoricCaseInstanceRestService api, string caseInstanceId)
        {
            _api = api;
            _caseInstanceId = caseInstanceId;
        }

        /// <summary>
        /// Retrieves a historic case instance by id, according to the <see cref="HistoricCaseInstance"/> interface in the engine.
        /// </summary>
        /// <returns></returns>
        public Task<HistoricCaseInstance> Get() => _api.Get(_caseInstanceId);
    }
}