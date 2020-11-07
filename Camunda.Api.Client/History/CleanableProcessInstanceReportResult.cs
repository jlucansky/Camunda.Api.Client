using System;
using System.Collections.Generic;
using System.Text;

namespace Camunda.Api.Client.History
{
    public class CleanableProcessInstanceReportResult
    {
        /// <summary>
        ///  The id of the process definition.
        /// </summary>
        public string ProcessDefinitionId;

        /// <summary>
        ///  The key of the process definition.
        /// </summary>
        public string ProcessDefinitionKey;

        /// <summary>
        /// The name of the process definition.
        /// </summary>
        public string ProcessDefinitionName;

        /// <summary>
        ///  The version of the process definition.
        /// </summary>
        public int ProcessDefinitionVersion;

        /// <summary>
        ///  The history time to live of the process definition.
        /// </summary>
        public int HistoryTimeToLive;

        /// <summary>
        ///  The count of the finished historic process instances.
        /// </summary>
        public int FinishedProcessInstanceCount;

        /// <summary>
        ///  The count of the cleanable historic process instances, referring to history time to live.
        /// </summary>
        public int CleanableProcessInstanceCount;

        /// <summary>
        ///  The tenant id of the process definition.
        /// </summary>
        public string TenantId;
    }
}
