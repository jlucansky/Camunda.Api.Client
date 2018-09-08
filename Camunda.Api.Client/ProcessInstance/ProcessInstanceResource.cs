using System.Threading.Tasks;

namespace Camunda.Api.Client.ProcessInstance
{
    public class ProcessInstanceResource
    {
        private string _processInstanceId;
        private IProcessInstanceRestService _api;

        internal ProcessInstanceResource(IProcessInstanceRestService api, string processInstanceId)
        {
            _api = api;
            _processInstanceId = processInstanceId;
        }

        /// <summary>
        /// Retrieves a single process instance according to the ProcessInstance interface in the engine.
        /// </summary>
        public Task<ProcessInstanceInfo> Get() => _api.Get(_processInstanceId);

        /// <summary>
        /// Deletes a running process instance.
        /// </summary>
        /// <param name="skipCustomListeners">If set to true, the custom listeners will be skipped.</param>
        /// <param name="skipIoMappings">If set to true, the input/output mappings will be skipped.</param>
        /// <param name="skipSubprocesses">If set to true, subprocesses related to deleted processes will be skipped.</param>
        public Task Delete(bool skipCustomListeners = false, bool skipIoMappings = false, bool skipSubprocesses = false) => _api.DeleteProcessInstance(_processInstanceId, skipCustomListeners, skipIoMappings, skipSubprocesses);

        /// <summary>
        /// Retrieves an Activity Instance (Tree) for a given process instance.
        /// </summary>
        public Task<ActivityInstanceInfo> GetActivityInstance() => _api.GetActivityInstanceTree(_processInstanceId);

        public Task UpdateSuspensionState(bool suspended) => _api.UpdateSuspensionStateForId(_processInstanceId, new SuspensionState() { Suspended = suspended });

        /// <summary>
        /// Submits a list of modification instructions to change a process instance's execution state.
        /// </summary>
        /// <param name="modification"></param>
        /// <returns></returns>
        /// <remarks>
        /// A modification instruction is one of the following:
        ///  * Starting execution before an activity
        ///  * Starting execution after an activity on its single outgoing sequence flow
        ///  * Starting execution on a specific sequence flow
        ///  * Cancelling an activity instance, transition instance, or all instances (activity or transition) for an activity
        ///  
        /// Instructions are executed immediately and in the order they are provided in this request's body. Variables can be provided with every starting instruction.
        /// </remarks>
        public Task ModifyProcessInstance(ProcessInstanceModification modification) => _api.ModifyProcessInstance(_processInstanceId, modification);

        public VariableResource Variables => new VariableResource(_api, _processInstanceId);

        public override string ToString() => _processInstanceId;
    }
}
