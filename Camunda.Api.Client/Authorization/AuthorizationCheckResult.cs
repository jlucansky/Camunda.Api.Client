using System;
using System.Collections.Generic;
using System.Text;

namespace Camunda.Api.Client.Authorization
{
    public class AuthorizationCheckResult
    {
        /// <summary>
        /// Name of the permission which was checked.
        /// </summary>
        public string PermissionName;

        /// <summary>
        /// The name of the resource for which the permission check was performed.
        /// </summary>
        public string ResourceName;

        /// <summary>
        /// The id of the resource for which the permission check was performed.
        /// </summary>
        public string ResourceId;

        /// <summary>
        /// True / false for isAuthorized.
        /// </summary>
        public bool IsAuthorized;


    }
}
