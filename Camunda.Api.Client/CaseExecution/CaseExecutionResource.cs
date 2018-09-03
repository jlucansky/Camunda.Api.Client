using System.Threading.Tasks;

namespace Camunda.Api.Client.CaseExecution
{
    public class CaseExecutionResource
    {
        private ICaseExecutionRestService _api;
        private string _caseExecutionId;

        internal CaseExecutionResource(ICaseExecutionRestService api, string caseExecutionId)
        {
            _api = api;
            _caseExecutionId = caseExecutionId;
        }

        public Task Start(CaseExecutionStart start) => _api.StartExecution(_caseExecutionId, start);

        public Task Complete(CaseExecutionComplete complete) => _api.CompleteExecution(_caseExecutionId, complete);

        public Task Disable(CaseExecutionDisable disable) => _api.DisableExecution(_caseExecutionId, disable);

        public Task ReEnable(CaseExecutionReEnable reEnable) => _api.ReEnableExecution(_caseExecutionId, reEnable);

        public Task Terminate(CaseExecutionTerminate terminate) => _api.TerminateExecution(_caseExecutionId, terminate);
    }
}