
using System.Collections.Generic;

namespace Camunda.Api.Client.ExternalTask
{
    public class FetchExternalTasks
    {
        /// <summary>
        /// Mandatory. The maximum number of tasks to return.
        /// </summary>
        public int MaxTasks;
        /// <summary>
        /// Mandatory. The id of the worker on which behalf tasks are fetched. The returned tasks are locked for that worker and can only be completed when providing the same worker id.
        /// </summary>
        public string WorkerId;

        /// <summary>
        /// Indicates whether the task should be fetched based on its priority or arbitrarily.
        /// </summary>
        public bool UsePriority;

        /// <summary>
        /// Array of topic objects for which external tasks should be fetched. The returned tasks may be arbitrarily distributed among these topics.
        /// </summary>
        public List<FetchExternalTaskTopic> Topics;
    }
}
