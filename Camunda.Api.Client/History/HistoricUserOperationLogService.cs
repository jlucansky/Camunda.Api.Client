using System.Collections.Generic;
using System.Threading.Tasks;

namespace Camunda.Api.Client.History
{
    public class HistoricUserOperationLogService
    {
        private IHistoricUserOperationLogRestService _api;

        internal HistoricUserOperationLogService(IHistoricUserOperationLogRestService api)
        {
            _api = api;
        }

        public QueryResource<HistoricUserOperationLogQuery, HistoricUserOperationLog> Query(HistoricUserOperationLogQuery query = null) =>
            new QueryResource<HistoricUserOperationLogQuery, HistoricUserOperationLog>(
                query,
                (q, f, m) => _api.GetList(q, f, m), 
                q => _api.GetListCount(q));

        /// <param name="historicOperationId">The id of the operation log entry.</param>
        public HistoricUserOperationLogResource this[string historicOperationId] => new HistoricUserOperationLogResource(_api, historicOperationId);
    }
}
