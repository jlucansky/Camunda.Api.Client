using System.Collections.Generic;

namespace Camunda.Api.Client.ProcessDefinition
{
    public class StatisticsResult
    {
        /// <summary>
        /// The id of the process definition the results are aggregated for.
        /// </summary>
        public string Id;
        /// <summary>
        /// The total number of running process instances of this process definition.
        /// </summary>
        public int Instances;
        /// <summary>
        /// The total number of failed jobs for the running instances.
        /// </summary>
        public int FailedJobs;

        public List<IncidentStatisticsResult> Incidents;

        public override string ToString() => Id;
    }
}
