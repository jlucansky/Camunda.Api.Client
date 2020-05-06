using Newtonsoft.Json;

namespace Camunda.Api.Client.Migration
{
    public class MigrationPlanRequest
    {
        /// <summary>
        /// The id of the source process definition for the migration.
        /// </summary>
        [JsonProperty("sourceProcessDefinitionId")]
        public string SourceProcessDefinitionId;

        /// <summary>
        /// The id of the target process definition for the migration.
        /// </summary>
        [JsonProperty("targetProcessDefinitionId")]
        public string TargetProcessDefinitionId;

        /// <summary>
        /// A boolean flag indicating whether instructions between events should be configured to update the event triggers.
        /// </summary>
        [JsonProperty("updateEventTriggers")]
        public bool UpdateEventTriggers;
    }
}
