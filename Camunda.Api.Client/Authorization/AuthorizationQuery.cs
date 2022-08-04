using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Camunda.Api.Client.Authorization
{
    public class AuthorizationQuery
    {
        /// <summary>
        /// Filter by the id of the authorization.
        /// </summary>
        public string Id;
        /// <summary>
        /// Filter by authorization type. (0=global, 1=grant, 2=revoke). See the User Guide for more information about authorization types.
        /// </summary>
        public AuthorizationTypeEnum Type;

        /// <summary>
        /// Filter by a comma-separated list of userIds.
        /// </summary>
        [JsonProperty("userIdIn")]
        public List<string> UserIds = new List<string>();

        /// <summary>
        /// Filter by a comma-separated list of groupIds.
        /// </summary>
        [JsonProperty("groupIdIn")]
        public List<string> GroupIds = new List<string>();

        /// <summary>
        /// Filter by an integer representation of the resource type. See the User Guide for a list of integer representations of resource types.
        /// </summary>
        public int ResourceType;

        /// <summary>
        /// Filter by resource id.
        /// </summary>
        public string ResourceId;

        /// <summary>
        /// Sort the results lexicographically by a given criterion. Must be used in conjunction with the <see cref="SortOrder"/> parameter. Note: Sorting by <see cref="VersionTag"/> is string based. The version will not be interpreted. As an example, the sorting could return v0.1.0, v0.10.0, v0.2.0.
        /// </summary>
        public AuthorizationSorting SortBy;
        /// <summary>
        /// Sort the results in a given order. Must be used in conjunction with the <see cref="SortBy"/> parameter.
        /// </summary>
        public SortOrder SortOrder;

    }


    

    public enum AuthorizationSorting
    {
        ResourceType,

        ResourceId

    }
}
