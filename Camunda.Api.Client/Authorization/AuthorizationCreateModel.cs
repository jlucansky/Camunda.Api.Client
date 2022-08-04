using System;
using System.Collections.Generic;
using System.Text;

namespace Camunda.Api.Client.Authorization
{
    public class AuthorizationCreateModel
    {
        /// <summary>
        /// An array of strings representing the permissions provided by this authorization.
        /// </summary>
        public List<string> Permissions;

        /// <summary>
        /// The id of the user this authorization has been created for. The value "*" represents a global authorization ranging over all users.
        /// </summary>
        public string UserId;

        /// <summary>
        /// The id of the group this authorization has been created for.
        /// </summary>
        public string GroupId;

        /// <summary>
        /// An integer representing the resource type. See the User Guide for a list of integer representations of resource types.
        /// </summary>
        public int ResourceType;

        /// <summary>
        /// The resource Id. The value "*" represents an authorization ranging over all instances of a resource.
        /// </summary>
        public string ResourceId;
    }
}
