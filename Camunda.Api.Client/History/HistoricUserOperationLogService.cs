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
        
        public Task<List<HistoricUserOperationLog>> GetHistoricAssignmentsOfProcess(string processInstanceId) => _api.GetHistoricAssignmentsOfProcess(processInstanceId);

        public Task<List<HistoricUserOperationLog>> GetHistoricAssignmentsOfTask(string taskInstanceId) => _api.GetHistoricAssignmentsOfTask(taskInstanceId);

        public QueryResource<HistoricUserOperationLogQuery, HistoricUserOperationLog> Query(HistoricUserOperationLogQuery query = null) =>
             new QueryResource<HistoricUserOperationLogQuery, HistoricUserOperationLog>(
                 query,
                 (q, f, m) => _api.GetList(q, f, m), 
                 q => _api.GetListCount(q));

        /// <param name="historicOperationId">The id of the operation log entry.</param>
         public HistoricUserOperationLogResource this[string historicOperationId] => new HistoricUserOperationLogResource(_api, historicOperationId);

    }
}