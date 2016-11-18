
namespace Camunda.Api.Client.ExternalTask
{
    public class ExternalTaskFailure
    {
        /// <summary>
        /// The id of the worker that reports the failure. Must match the id of the worker who has most recently locked the task.
        /// </summary>
        public string WorkerId;

        /// <summary>
        /// An message indicating the reason of the failure.
        /// </summary>
        public string ErrorMessage;

        /// <summary>
        /// A timeout in milliseconds before the external task becomes available again for fetching. Must be >= 0.
        /// </summary>
        public long RetryTimeout;

        /// <summary>
        /// A number of how often the task should be retried. Must be >= 0. If this is 0, an incident is created and the task cannot be fetched anymore unless the retries are increased again. The incident's message is set to the errorMessage parameter.
        /// </summary>
        public int Retries;

        public override string ToString() => ErrorMessage;
    }
}
