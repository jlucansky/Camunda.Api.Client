using Camunda.Api.Client.UserTask;
using System;
using System.Runtime.Serialization;

namespace Camunda.Api.Client.History
{
    public class HistoricTask: UserTaskInfo
    {
        /// <summary>
        /// Whether the task belongs to a process instance that is suspended.
        /// </summary>
        public bool Suspended;
    }
}
