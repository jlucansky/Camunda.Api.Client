using Camunda.Api.Client.UserTask;
using System;

namespace Camunda.Api.Client.History
{
    public class HistoricTask: UserTaskInfo
    {
        /// <summary>
        /// Whether the task belongs to a process instance that is suspended.
        /// </summary>
        public bool Suspended;

        public DateTime? StartTime;

        public DateTime? EndTime;
    }
}
