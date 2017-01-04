using System.Threading.Tasks;

namespace Camunda.Api.Client.History
{
    public class HistoricJobLogResource
    {
        private IHistoricJobLogRestService _api;
        private string _historicJobLogId;

        internal HistoricJobLogResource(IHistoricJobLogRestService api, string historicJobLogId)
        {
            _api = api;
            _historicJobLogId = historicJobLogId;
        }

        /// <summary>
        /// Retrieves a historic job log by id.
        /// </summary>
        public Task<HistoricJobLog> Get() => _api.Get(_historicJobLogId);

        /// <summary>
        /// Retrieves the corresponding exception stacktrace to the passed historic job log by id.
        /// </summary>
        public async Task<string> GetStacktrace() => await (await _api.GetStacktrace(_historicJobLogId)).Content.ReadAsStringAsync();
    }
}
