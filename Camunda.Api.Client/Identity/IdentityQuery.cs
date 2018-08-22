using System;
using System.Collections.Generic;
using System.Text;

namespace Camunda.Api.Client.Identity
{
    public class IdentityQuery : QueryParameters
    {
        public IdentityQuery(string userId)
        {
            UserId = userId;
        }
        /// <summary>
        /// Specify the id of the user.
        /// </summary>
        public string UserId;
    }
}
