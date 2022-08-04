using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Camunda.Api.Client.Authorization
{
    public enum AuthorizationTypeEnum
    {
        /// <summary>
        /// global
        /// </summary>
        [EnumMember(Value = "0")]
        Global = 0,

        /// <summary>
        /// grant
        /// </summary
        [EnumMember(Value = "1")]
        Grant = 1,

        /// <summary>
        /// revoke
        /// </summary>
        [EnumMember(Value = "2")]
        Revoke = 2,
    }

}
