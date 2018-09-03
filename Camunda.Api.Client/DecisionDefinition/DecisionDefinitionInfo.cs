namespace Camunda.Api.Client.DecisionDefinition
{
    public class DecisionDefinitionInfo
    {
        /// <summary>
        /// The id of the decision definition.
        /// </summary>
        public string Id;

        /// <summary>
        /// The key of the decision definition, i.e.the id of the DMN 1.0 XML decision definition.
        /// </summary>
        public string Key;

        /// <summary>
        /// The category of the decision definition.
        /// </summary>
        public string Category;

        /// <summary>
        /// The name of the decision definition.
        /// </summary>
        public string Name;

        /// <summary>
        /// The version of the decision definition that the engine assigned to it.
        /// </summary>
        public int Version;

        /// <summary>
        /// The file name of the decision definition.
        /// </summary>
        public string Resource;

        /// <summary>
        /// The deployment id of the decision definition.
        /// </summary>
        public string DeploymentId;

        /// <summary>
        /// The tenant id of the decision definition.
        /// </summary>
        public string TenantId;

        public override string ToString() => Id;
    }
}