using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Camunda.Api.Client.History
{
    public class HistoricActivityStatistics : QueryParameters
    {
        /// <summary>
        /// Whether to include the number of canceled activity instances in the result or not. Valid values are true or false. Default: false.
        /// </summary>
        public bool Canceled;

        /// <summary>
        /// Whether to include the number of finished activity instances in the result or not. Valid values are true or false. Default: false.
        /// </summary>
        public bool Finished;

        /// <summary>
        /// Whether to include the number of activity instances which completed a scope in the result or not. Valid values are true or false. Default: false.
        /// </summary>
        public bool CompleteScope;

        /// <summary>
        /// Whether to include the number of incidents. Valid values are true or false. Default: false.
        /// </summary>
        public bool Incidents;

        /// <summary>
        /// Restrict to instances that were started before the given date.
        /// </summary>
        public DateTime? StartedBefore;

        /// <summary>
        /// Restrict to instances that were started after the given date.
        /// </summary>
        public DateTime? StartedAfter;

        /// <summary>
        /// Restrict to instances that were finished before the given date.
        /// </summary>
        public DateTime? FinishedBefore;

        /// <summary>
        /// Restrict to instances that were finished after the given date.
        /// </summary>
        public DateTime? FinishedAfter;

        /// <summary>
        /// Filter by the key of the process definition the instances run on.
        /// </summary>
        [JsonProperty("processInstanceIdIn")]
        public List<string> ProcessInstanceIds;

        /// <summary>
        /// Sort the results by a given criterion. A valid value is activityId. Must be used in conjunction with the sortOrder parameter.
        /// </summary>
        public HistoricActivityStatisticsSorting SortBy;

        /// <summary>
        /// Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter.
        /// </summary>
        public SortOrder SortOrder;
    }

    public enum HistoricActivityStatisticsSorting
    {
        ActivityId
    }
}