namespace Camunda.Api.Client.ExternalTask
{
    public class ExternalTaskLock
    {
        /// <summary>
        /// The ID of a worker who is locking the external task.
        /// </summary>
        public string WorkerId;

        /// <summary>
        /// An amount of time (in milliseconds) to extend the lock by.
        /// </summary>
        public long Duration;
    }
}
