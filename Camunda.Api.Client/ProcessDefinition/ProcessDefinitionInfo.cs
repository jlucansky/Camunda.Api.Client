
namespace Camunda.Api.Client.ProcessDefinition
{
    public class ProcessDefinitionInfo
    {
        /// <summary>
        /// The id of the process definition.
        /// </summary>
        public string Id;
        /// <summary>
        /// The key of the process definition, i.e. the id of the BPMN 2.0 XML process definition.
        /// </summary>
        public string Key;
        /// <summary>
        /// The category of the process definition.
        /// </summary>
        public string Category;
        /// <summary>
        /// The description of the process definition.
        /// </summary>
        public string Description;
        /// <summary>
        /// The name of the process definition.
        /// </summary>
        public string Name;
        /// <summary>
        /// The version of the process definition that the engine assigned to it.
        /// </summary>
        public int Version;
        /// <summary>
        /// The file name of the process definition.
        /// </summary>
        public string Resource;
        /// <summary>
        /// The deployment id of the process definition.
        /// </summary>
        public string DeploymentId;
        /// <summary>
        /// History time to live value of the process definition. Is used within History cleanup.
        /// </summary>
        public int HistoryTimeToLive;
        /// <summary>
        /// A flag indicating whether the process definition is startable in Tasklist or not.
        /// </summary>
        public bool StartableInTasklist;
        /// <summary>
        /// The file name of the process definition diagram, if it exists.
        /// </summary>
        public string Diagram;
        /// <summary>
        /// A flag indicating whether the definition is suspended or not.
        /// </summary>
        public bool Suspended;
        /// <summary>
        /// The tenant id of the process definition.
        /// </summary>
        public string TenantId;
        /// <summary>
        /// The version tag of the process definition.
        /// </summary>
        public string VersionTag;

        public override string ToString() => Id;
    }
}
