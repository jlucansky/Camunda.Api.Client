using Camunda.Api.Client.UserTask;
using System;

namespace Camunda.Api.Client.History
{
    public class HistoricTask: UserTaskInfo
    {
        /// <summary>
        /// Indicates the start time of the task.
        /// </summary>
        public DateTime? StartTime;

        /// <summary>
        /// Indicates the end time of the task.
        /// </summary>
        public DateTime? EndTime;

         /// <summary>
         ///  The id of the activity that this object is an instance of.
         /// </summary>
         public string ActivityInstanceId;

         /// <summary>
         /// The task's delete reason.
         /// </summary>
         public string DeleteReason;

         /// <summary>
         /// The time the task took to finish (in milliseconds).
         /// </summary>
         public long Duration;

         /// <summary>
         /// The time after which the task should be removed by the History Cleanup job. Default format* yyyy-MM-dd'T'HH:mm:ss.SSSZ.
         /// </summary>
         public string RemovalTime;

         /// <summary>
         /// The process instance id of the root process instance that initiated the process containing this task.
         /// </summary>
         public string RootProcessInstanceId;

    }
}
