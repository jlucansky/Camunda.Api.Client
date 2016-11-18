using Newtonsoft.Json;
using Refit;
using System.Collections.Generic;

namespace Camunda.Api.Client.ProcessDefinition
{
    public class ProcessDefinitionQuery : IQueryParameters
    {
        /// <summary>
        /// Filter by process definition id.
        /// </summary>
        public string ProcessDefinitionId;
        /// <summary>
        /// Filter by process definition ids.
        /// </summary>
        [JsonProperty("processDefinitionIdIn")]
        public List<string> ProcessDefinitionIds = new List<string>();
        /// <summary>
        /// Filter by process definition category. Exact match.
        /// </summary>
        public string Category;
        /// <summary>
        /// Filter by process definition categories that the parameter is a substring of.
        /// </summary>
        public string CategoryLike;
        /// <summary>
        /// Filter by process definition name.
        /// </summary>
        public string Name;
        /// <summary>
        /// Filter by process definition names that the parameter is a substring of.
        /// </summary>
        public string NameLike;
        /// <summary>
        /// Filter by the deployment the id belongs to.
        /// </summary>
        public string DeploymentId;
        /// <summary>
        /// Filter by process definition key, i.e. the id in the BPMN 2.0 XML. Exact match.
        /// </summary>
        public string Key;
        /// <summary>
        /// Filter by process definition keys that the parameter is a substring of.
        /// </summary>
        public string KeyLike;
        /// <summary>
        /// Filter by the name of the process definition resource. Exact match.
        /// </summary>
        public string ResourceName;
        /// <summary>
        /// Filter by names of those process definition resources that the parameter is a substring of.
        /// </summary>
        public string ResourceNameLike;
        /// <summary>
        /// Filter by process definition version.
        /// </summary>
        public int? Version;
        /// <summary>
        /// Only include those process definitions that are latest versions. Value may only be true, as false is the default behavior.
        /// </summary>
        /// <remarks>
        /// Can only be used in combination with Key or KeyLike. Can also be used without any other criteria which will then give all the latest versions of all the deployed process definitions.
        /// For multi-tenancy: select the latest deployed process definitions for each tenant. If a process definition is deployed for multiple tenants then all process definitions are selected.
        /// </remarks>
        public bool LatestVersion = false;
        /// <summary>
        /// Only include suspended process definitions. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool Suspended = false;
        /// <summary>
        /// Only selects process definitions with the given incident type.
        /// </summary>
        public string IncidentType;
        /// <summary>
        /// Only selects process definitions with the given incident id.
        /// </summary>
        public string IncidentId;
        /// <summary>
        /// Only selects process definitions with the given incident message.
        /// </summary>
        public string IncidentMessage;
        /// <summary>
        /// Only selects process definitions with an incident message like the given.
        /// </summary>
        public string IncidentMessageLike;
        /// <summary>
        /// Filter by a comma-separated list of tenant ids. A process definition must have one of the given tenant ids.
        /// </summary>
        [JsonProperty("tenantIdIn")]
        public List<string> TenantIds = new List<string>();
        /// <summary>
        /// Include process definitions which belongs to no tenant. Can be used in combination with tenantIdIn. Value may only be true, as false is the default behavior.
        /// </summary>
        [JsonProperty("includeProcessDefinitionsWithoutTenantId")]
        public bool IncludeDefinitionsWithoutTenantId = false;
        /// <summary>
        /// Filter by the version tag.
        /// </summary>
        public string VersionTag;
        /// <summary>
        /// Filter by the version tag that the parameter is a substring of.
        /// </summary>
        public string VersionTagLike;
        /// <summary>
        /// Sort the results lexicographically by a given criterion. Must be used in conjunction with the sortOrder parameter. Note: Sorting by versionTag is string based. The version will not be interpreted. As an example, the sorting could return v0.1.0, v0.10.0, v0.2.0.
        /// </summary>
        public ProcessDefinitionSorting SortBy;
        /// <summary>
        /// Sort the results in a given order. Must be used in conjunction with the sortBy parameter.
        /// </summary>
        public SortOrder SortOrder;

        IDictionary<string, string> IQueryParameters.GetParameters()
        {
            return this.CreateQueryParameters();
        }
    }

    public enum ProcessDefinitionSorting
    {
        Id,
        Key,
        Category,
        Name,
        Version,
        DeploymentId,
        TenantId,
        VersionTag
    }
}
