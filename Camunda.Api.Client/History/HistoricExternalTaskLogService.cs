using System.Collections.Generic;
using System.Threading.Tasks;

namespace Camunda.Api.Client.History
{
    public class HistoricExternalTaskLogService
    {
        private IHistoricExternalTaskLogRestService _api;

        internal HistoricExternalTaskLogService(IHistoricExternalTaskLogRestService api)
        {
            _api = api;
        }

        public QueryResource<HistoricExternalTaskLogQuery, HistoricExternalTaskLog> Query(HistoricExternalTaskLogQuery query = null) =>
            new QueryResource<HistoricExternalTaskLogQuery, HistoricExternalTaskLog>(
                query,
                (q, f, m) => _api.GetList(q, f, m), 
                q => _api.GetListCount(q));

        public HistoricExternalTaskLogResource this[string logId] => new HistoricExternalTaskLogResource(_api, logId);
    }
}
