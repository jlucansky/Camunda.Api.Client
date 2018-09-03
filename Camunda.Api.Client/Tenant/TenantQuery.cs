using System;
using System.Collections.Generic;
using System.Text;

namespace Camunda.Api.Client.Tenant
{
    public class TenantQuery : QueryParameters
    {
        //id Filter by the id of the tenant.
        //name    Filter by the name of the tenant.
        //nameLike Filter by the name that the parameter is a substring of.
        //userMember Select only tenants where the given user is a member of.
        //groupMember Select only tenants where the given group is a member of.
        //includingGroupsOfUser Select only tenants where the user or one of his groups is a member of.Can only be used in combination with the userMember parameter.Value may only be true, as false is the default behavior.
        //sortBy Sort the results lexicographically by a given criterion.Valid values are id and name. Must be used in conjunction with the sortOrder parameter.
        //sortOrder Sort the results in a given order.Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter.
        //firstResult Pagination of results. Specifies the index of the first result to return.
        //maxResults Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left.
    }
}
