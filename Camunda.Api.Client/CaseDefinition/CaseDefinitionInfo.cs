namespace Camunda.Api.Client.CaseDefinition
{
    public class CaseDefinitionInfo
    {
        /// <summary>
        /// The id of the case definition.
        /// </summary>
        public string Id;

        /// <summary>
        /// The key of the case definition, i.e. the id of the CMMN XML case definition.
        /// </summary>
        public string Key;

        /// <summary>
        /// The category of the case definition.
        /// </summary>
        public string Category;

        /// <summary>
        /// The name of the case definition.
        /// </summary>
        public string Name;

        /// <summary>
        /// The version of the case definition that the engine assigned to it.
        /// </summary>
        public int Version;

        /// <summary>
        /// The file name of the case definition.
        /// </summary>
        public string Resource;

        /// <summary>
        /// The deployment id of the case definition.
        /// </summary>
        public string DeploymentId;

        /// <summary>
        /// The tenant id of the case definition.
        /// </summary>
        public string TenantId;

        /// <summary>
        /// History time to live value of the case definition. Is used within History cleanup.
        /// </summary>
        public int HistoryTimeToLive;

        public override string ToString() => Id;
    }
}