using Newtonsoft.Json;
using System.Collections.Generic;

namespace Camunda.Api.Client.ProcessInstance
{
    public class JobRetriesByProcess
    {
        /// <summary>
        /// A list of process instance ids to fetch jobs, for which retries will be set.
        /// </summary>
        [JsonProperty("processInstances")]
        public List<string> ProcessInstanceIds = new List<string>();
        /// <summary>
        /// A process instance query like the request body for <see cref="ProcessInstanceService.Query(ProcessInstanceQuery)"/>.
        /// </summary>
        public ProcessInstanceQuery ProcessInstanceQuery = new ProcessInstanceQuery();
        /// <summary>
        /// An integer representing the number of retries.
        /// </summary>
        public int Retries;
    }
}
