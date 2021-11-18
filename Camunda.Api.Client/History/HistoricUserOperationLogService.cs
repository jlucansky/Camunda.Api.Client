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
        
        /// <summary>
        /// Get all the user assignments that were made for the processInstanceId
        /// It can also be done with the Query method.
        /// </summary>
        /// <param name="processInstanceId">The id of the process instance.</param>
        public Task<List<HistoricUserOperationLog>> GetHistoricAssignmentsOfProcess(string processInstanceId) => _api.GetHistoricAssignmentsOfProcess(processInstanceId);

        /// <summary>
        /// Get all the user assignments that were made for the taskInstanceId
        /// It can also be done with the Query method.
        /// </summary>
        /// <param name="taskInstanceId">The id of the task instance.</param>
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