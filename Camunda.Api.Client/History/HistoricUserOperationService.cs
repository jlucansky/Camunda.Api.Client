
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Camunda.Api.Client.History
{
    public class HistoricUserOperationService
    {
        private IHistoricUserOperationRestService _api;


        internal HistoricUserOperationService(IHistoricUserOperationRestService api)
        {
            _api = api;
        }
        
        public Task<List<HistoricUserOperation>> GetHistoricAssignmentsOfProcess(string processInstanceId) => _api.GetHistoricAssignmentsOfProcess(processInstanceId);

        public Task<List<HistoricUserOperation>> GetHistoricAssignmentsOfTask(string taskInstanceId) => _api.GetHistoricAssignmentsOfTask(taskInstanceId);



    }
}
