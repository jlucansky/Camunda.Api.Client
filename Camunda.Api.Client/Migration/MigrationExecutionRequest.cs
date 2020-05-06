using System.Collections.Generic;
using Camunda.Api.Client.ProcessInstance;
using Newtonsoft.Json;

namespace Camunda.Api.Client.Migration
{
    public class MigrationExecutionRequest
    {
        /// <summary>
        /// The migration plan to execute.
        /// </summary>
        [JsonProperty("migrationPlan")]
        public MigrationPlan MigrationPlan;

        /// <summary>
        /// A list of process instance ids to migrate.
        /// </summary>
        [JsonProperty("processInstanceIds")]
        public List<string> ProcessInstanceIds;

        /// <summary>
        /// A process instance query.
        /// </summary>
        [JsonProperty("processInstanceQuery")]
        public ProcessInstanceQuery processInstanceQuery;

        /// <summary>
        /// A boolean value to control whether execution listeners should be invoked during migration.
        /// </summary>
        [JsonProperty("skipCustomListeners")]
        public bool SkipCustomListeners;

        /// <summary>
        /// A boolean value to control whether input/output mappings should be executed during migration.
        /// </summary>
        [JsonProperty("skipIoMappings")]
        public bool SkipIoMappings;
    }
}
