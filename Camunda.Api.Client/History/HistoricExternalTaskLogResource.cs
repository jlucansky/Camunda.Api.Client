using System.Threading.Tasks;

namespace Camunda.Api.Client.History
{
    public class HistoricExternalTaskLogResource
    {
        private IHistoricExternalTaskLogRestService _api;
        private string _logId;

        internal HistoricExternalTaskLogResource(IHistoricExternalTaskLogRestService api, string logId)
        {
            _api = api;
            _logId = logId;
        }

        /// <summary>
        /// Retrieves a historic external task log by id.
        /// </summary>
        /// <returns></returns>
        public Task<HistoricExternalTaskLog> Get() => _api.Get(_logId);

        /// <summary>
        /// Retrieves the corresponding exception stacktrace to the passed historic job log by id.
        /// </summary>
        public async Task<string> GetErrorDetails() => await (await _api.GetErrorDetails(_logId)).Content.ReadAsStringAsync();
    }
}