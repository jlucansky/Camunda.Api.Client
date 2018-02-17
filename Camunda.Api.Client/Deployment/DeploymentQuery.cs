using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Camunda.Api.Client.Deployment
{
    public class DeploymentQuery : QueryParameters
    {
        /// <summary>
        /// Filter by deployment id.
        /// </summary>
        public string Id;
        /// <summary>
        /// Filter by the deployment name. Exact match.
        /// </summary>
        public string Name;
        /// <summary>
        /// Filter by the deployment name that the parameter is a substring of. The parameter can include the wildcard % to express like-strategy such as: starts with (%name), ends with (name%) or contains (%name%).
        /// </summary>
        public string NameLike;
        /// <summary>
        /// Filter by the deployment source.
        /// </summary>
        public string Source;
        /// <summary>
        /// Filter by the deployment source whereby source is equal to null.
        /// </summary>
        public bool WithoutSource;
        /// <summary>
        /// Restricts to all deployments before the given date.
        /// </summary>
        public DateTime? Before;
        /// <summary>
        /// Restricts to all deployments after the given date.
        /// </summary>
        public DateTime? After;
        /// <summary>
        /// Filter by a comma-separated list of tenant ids. A deployment must have one of the given tenant ids.
        /// </summary>
        [JsonProperty("tenantIdIn")]
        public List<string> TenantIds = new List<string>();
        /// <summary>
        /// Only include deployments which belongs to no tenant. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool WithoutTenantId;
        /// <summary>
        /// Include deployments which belongs to no tenant. Can be used in combination with tenantIdIn. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool IncludeDeploymentsWithoutTenantId;
        /// <summary>
        /// Sort the results lexicographically by a given criterion. Must be used in conjunction with the <see cref="SortOrder"/> parameter.
        /// </summary>
        public DeploymentSorting SortBy;
        /// <summary>
        /// Sort the results in a given order. Must be used in conjunction with the <see cref="SortBy"/> parameter.
        /// </summary>
        public SortOrder SortOrder;
    }

    public enum DeploymentSorting
    {
        Id,
        Name,
        DeploymentTime,
        TenantId
    }
}
