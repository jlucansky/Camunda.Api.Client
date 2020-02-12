using System.Threading.Tasks;

namespace Camunda.Api.Client.ExternalTask
{
    public class ExternalTaskResource
    {
        private string _externalTaskId;
        private IExternalTaskRestService _api;

        internal ExternalTaskResource(IExternalTaskRestService api, string externalTaskId)
        {
            _api = api;
            _externalTaskId = externalTaskId;
        }

        /// <summary>
        /// Retrieves a single external task corresponding to the ExternalTask interface in the engine.
        /// </summary>
        public Task<ExternalTaskInfo> Get() => _api.Get(_externalTaskId);

        /// <summary>
        /// Set the number of retries left to execute an external task. If retries are set to 0, an incident is created.
        /// </summary>
        /// <param name="retries">The number of retries to set for the external task. Must be >= 0. If this is 0, an incident is created and the task cannot be fetched anymore unless the retries are increased again.</param>
        public Task SetRetries(int retries) => _api.SetRetries(_externalTaskId, new RetriesInfo() { Retries = retries });

        /// <summary>
        /// Set the priority of an existing external task. The default value of a priority is 0.
        /// </summary>
        /// <param name="priority">The priority of the external task.</param>
        public Task SetPriority(long priority) => _api.SetPriority(_externalTaskId, new PriorityInfo { Priority = priority });

        /// <summary>
        /// Complete an external task and update process variables.
        /// </summary>
        public Task Complete(CompleteExternalTask completeExternalTask) => _api.Complete(_externalTaskId, completeExternalTask);

        /// <summary>
        /// Report a failure to execute an external task. A number of retries and a timeout until the task can be retried can be specified. If retries are set to 0, an incident for this task is created.
        /// </summary>
        public Task HandleFailure(ExternalTaskFailure externalTaskFailure) => _api.HandleFailure(_externalTaskId, externalTaskFailure);

        /// <summary>
        /// Report a business error in the context of a running external task. The error code must be specified to identify the BPMN error handler.
        /// </summary>
        public Task HandleBpmnError(ExternalTaskBpmnError externalTaskBpmnError) => _api.HandleBpmnError(_externalTaskId, externalTaskBpmnError);

        /// <summary>
        /// Unlock an external task. Clears the task’s lock expiration time and worker id.
        /// </summary>
        public Task Unlock() => _api.Unlock(_externalTaskId);

        /// <summary>
        /// Extends the timeout of the lock by a given amount of time.
        /// </summary>
        public Task ExtendLock(ExternalTaskExtendLock externalTaskExtendLock) => _api.ExtendLock(_externalTaskId, externalTaskExtendLock);

        public override string ToString() => _externalTaskId;
    }
}
