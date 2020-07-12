using System.Collections.Generic;
using Newtonsoft.Json;

namespace Camunda.Api.Client.Migration
{
    public class MigrationInstruction
    {
        /// <summary>
        /// The activity ids from the source process definition being mapped.
        /// </summary>
        [JsonProperty("sourceActivityIds")]
        public List<string> SourceActivityIds;

        /// <summary>
        /// The activity ids from the target process definition being mapped.
        /// </summary>
        [JsonProperty("targetActivityIds")]
        public List<string> TargetActivityIds;

        /// <summary>
        /// Configuration flag whether event triggers defined are going to be updated during migration.
        /// </summary>
        [JsonProperty("updateEventTrigger")]
        public bool UpdateEventTrigger;
    }
}
