using System;
using System.Collections.Generic;
using System.Text;

namespace Camunda.Api.Client.Authorization
{
    public class AuthorizationCheckQuery
    {
        /// <summary>
        /// String value representing the permission name to check for.
        /// </summary>
        public string PermissionName;


        /// <summary>
        /// String value for the name of the resource to check permissions for.
        /// </summary>
        public string ResourceName;

        /// <summary>
        /// An integer representing the resource type to check permissions for. See the User Guide for a list of integer representations of resource types.
        /// </summary>
        public int ResourceType;

        /// <summary>
        /// 	The id of the resource to check permissions for. If left blank, a check for global permissions on the resource is performed.
        /// </summary>
        public string ResourceId;


        /// <summary>
        /// The id of the user to check permissions for. The currently authenticated user must have a READ permission for the Authorization resource. If userId is blank, a check for the currently authenticated user is performed.
        /// </summary>
        public string UserId;


    }
}
