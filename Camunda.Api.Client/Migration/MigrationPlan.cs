using System.Collections.Generic;
using Newtonsoft.Json;

namespace Camunda.Api.Client.Migration
{
    public class MigrationPlan
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
        /// A list of migration instructions which map equal activities.
        /// </summary>
        [JsonProperty("instructions")]
        public List<MigrationInstruction> Instructions;
    }
}
