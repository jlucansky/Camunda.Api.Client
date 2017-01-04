namespace Camunda.Api.Client.History
{
    public class HistoricJobLogService
    {
        private IHistoricJobLogRestService _api;

        internal HistoricJobLogService(IHistoricJobLogRestService api)
        {
            _api = api;
        }

        public QueryResource<HistoricJobLogQuery, HistoricJobLog> Query(HistoricJobLogQuery query = null) =>
            new QueryResource<HistoricJobLogQuery, HistoricJobLog>(_api, query);

        /// <param name="historicJobLogId">The id of the log entry.</param>
        public HistoricJobLogResource this[string historicJobLogId] => new HistoricJobLogResource(_api, historicJobLogId);
    }
}
