namespace Camunda.Api.Client.DecisionDefinition
{
    public class DecisionDefinitionInfo
    {
        /// <summary>
        /// The id of the decision definition.
        /// </summary>
        public string Id;

        /// <summary>
        /// The category of the decision definition.
        /// </summary>
        public string Category;

        /// <summary>
        /// The id of the decision requirements definition this decision definition belongs to.
        /// </summary>
        public string DecisionRequirementsDefinitionId;

        /// <summary>
        /// The key of the decision requirements definition this decision definition belongs to.
        /// </summary>
        public string DecisionRequirementsDefinitionKey;

        /// <summary>
        /// The deployment id of the decision definition.
        /// </summary>
        public string DeploymentId;

        /// <summary>
        /// History time to live value of the decision definition. Is used within LINK.
        /// </summary>
        public int HistoryTimeToLive;

        /// <summary>
        /// The key of the decision definition, i.e., the id of the DMN 1.0 XML decision definition.
        /// </summary>
        public string Key;

        /// <summary>
        /// The name of the decision definition.
        /// </summary>
        public string Name;

        /// <summary>
        /// The file name of the decision definition.
        /// </summary>
        public string Resource;

        /// <summary>
        /// The tenant id of the decision definition.
        /// </summary>
        public string TenantId;

        /// <summary>
        /// The version of the decision definition that the engine assigned to it.
        /// </summary>
        public int Version;

        /// <summary>
        /// The version tag of the decision or null when no version tag is set
        /// </summary>
        public string VersionTag;

        /// <summary>
        /// Filter by the version tag that the parameter is a substring of.
        /// </summary>
        public string VersionTagLike;

        public override string ToString() => Id;
    }
}
