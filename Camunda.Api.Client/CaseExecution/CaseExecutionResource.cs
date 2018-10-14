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

        // TODO: Variables, LocalVariables


        /// <summary>
        /// Retrieves a case execution by id, according to the CaseExecution interface in the engine.
        /// </summary>
        public Task<CaseExecutionInfo> Get() => _api.Get(_caseExecutionId);

        /// <summary>
        /// Performs a transition from ENABLED state to ACTIVE state. In relation to the state transition, it is possible to update or delete case instance variables (please note: deletion precedes update).
        /// </summary>
        public Task Start(CaseExecutionStart start) => _api.StartExecution(_caseExecutionId, start);

        /// <summary>
        /// Performs a transition from ACTIVE state to COMPLETED state. In relation to the state transition, it is possible to update or delete case instance variables (please note: deletion precedes update).
        /// </summary>
        public Task Complete(CaseExecutionComplete complete) => _api.CompleteExecution(_caseExecutionId, complete);

        /// <summary>
        /// Performs a transition from ENABLED state to DISABLED state. In relation to the state transition, it is possible to update or delete case instance variables (please note: deletion precedes update).
        /// </summary>
        public Task Disable(CaseExecutionDisable disable) => _api.DisableExecution(_caseExecutionId, disable);

        /// <summary>
        /// Performs a transition from DISABLED state to ENABLED state. In relation to the state transition, it is possible to update or delete case instance variables (please note: deletion precedes update).
        /// </summary>
        public Task ReEnable(CaseExecutionReEnable reEnable) => _api.ReEnableExecution(_caseExecutionId, reEnable);

        /// <summary>
        /// Performs a transition from ACTIVE state to TERMINATED state if the execution belongs to a task or a stage and performs a transition from AVAILABLE state to TERMINATED state if the execution belongs to a milestone. In relation to the state transition, it is possible to update or delete case instance variables (please note: deletion precedes update).
        /// </summary>
        public Task Terminate(CaseExecutionTerminate terminate) => _api.TerminateExecution(_caseExecutionId, terminate);
    }
}
