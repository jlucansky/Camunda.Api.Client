using System;
using System.Collections.Generic;
using System.Text;

namespace Camunda.Api.Client.Authorization
{
    public class AuthorizationInfo
    {
        /// <summary>
        /// The id of the authorization.
        /// </summary>
        public string Id;

        /// <summary>
        /// The type of the authorization. (0=global, 1=grant, 2=revoke).
        /// </summary>
        public AuthorizationTypeEnum Type;

        /// <summary>
        /// An array of Strings holding the permissions provided by this authorization.
        /// </summary>
        public List<string> Permissions = new List<string>();


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

        /// <summary>
        /// The removal time indicates the date a historic instance authorization is cleaned up. A removal time can only be assigned to a historic instance authorization. Can be null when not related to a historic instance resource or when the removal time strategy is end and the root process instance is not finished. Default format yyyy-MM-dd'T'HH:mm:ss.SSSZ.
        /// </summary>
        public string RemovalTime;

        /// <summary>
        /// The process instance id of the root process instance the historic instance authorization is related to. Can be null if not related to a historic instance resource.
        /// </summary>
        public string RootProcessInstanceId;

        public override string ToString() => Id;
    }
}
