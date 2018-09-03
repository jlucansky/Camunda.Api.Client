using Newtonsoft.Json;
using System.Collections.Generic;

namespace Camunda.Api.Client.CaseDefinition
{
    public class CaseDefinitionQuery : QueryParameters
    {
        /// <summary>
        /// Filter by case definition id.
        /// </summary>
        public string CaseDefinitionId;

        /// <summary>
        /// Filter by case definition ids.
        /// </summary>
        [JsonProperty("caseDefinitionIdIn")]
        public List<string> CaseDefinitionIds = new List<string>();

        /// <summary>
        /// Filter by case definition name.
        /// </summary>
        public string Name;

        /// <summary>
        /// Filter by case definition names that the parameter is a substring of.
        /// </summary>
        public string NameLike;

        /// <summary>
        /// Filter by the deployment the id belongs to.
        /// </summary>
        public string DeploymentId;

        /// <summary>
        /// Filter by case definition key, i.e., the id in the CMMN XML.Exact match.
        /// </summary>
        public string Key;

        /// <summary>
        /// Filter by case definition keys that the parameter is a substring of.
        /// </summary>
        public string KeyLike;

        /// <summary>
        /// Filter by case definition category. Exact match.
        /// </summary>
        public string Category;

        /// <summary>
        /// Filter by case definition categories that the parameter is a substring of.
        /// </summary>
        public string CategoryLike;

        /// <summary>
        /// Filter by case definition version.
        /// </summary>
        public int? Version;

        /// <summary>
        /// Only include those case definitions that are latest versions. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool LatestVersion = false;

        /// <summary>
        /// Filter by the name of the case definition resource. Exact match.
        /// </summary>
        public string ResourceName;

        /// <summary>
        /// Filter by names of those case definition resources that the parameter is a substring of.
        /// </summary>
        public string ResourceNameLike;

        /// <summary>
        /// Filter by a comma-separated list of tenant ids. A case definition must have one of the given tenant ids.
        /// </summary>
        [JsonProperty("tenantIdIn")]
        public List<string> TenantIds = new List<string>();

        /// <summary>
        /// Only include case definitions which belong to no tenant. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool WithoutTenantId = false;

        /// <summary>
        /// Include case definitions which belong to no tenant. Can be used in combination with tenantIdIn. Value may only be true, as false is the default behavior.
        /// </summary>
        [JsonProperty("includeCaseDefinitionsWithoutTenantId")]
        public bool IncludeDefinitionsWithoutTenantId = false;

        /// <summary>
        /// Sort the results lexicographically by a given criterion. Must be used in conjunction with the <see cref="SortOrder"/> parameter.
        /// </summary>
        public CaseDefinitionQuerySorting SortBy;

        /// <summary>
        /// Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter.
        /// </summary>
        public SortOrder SortOrder;
    }

    public enum CaseDefinitionQuerySorting
    {
        Category,
        Key,
        Id,
        Name,
        Version,
        DeploymentId,
        TenantId
    }
}