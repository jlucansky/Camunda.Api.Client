using System;
using System.Collections.Generic;

namespace Camunda.Api.Client
{
    public abstract class SortableQuery<TSortingEnum, TQuery> 
        where TQuery: SortableQuery<TSortingEnum, TQuery>
        where TSortingEnum : struct, IConvertible
    {
        /// <summary>
        /// Array of criteria to sort the result by. The position in the array identifies the rank of an ordering, i.e. whether it is primary, secondary, etc.
        /// </summary>
        public List<SortingInfo<TSortingEnum>> Sorting = new List<SortingInfo<TSortingEnum>>();

        public TQuery Sort(TSortingEnum sortBy, SortOrder sortOrder = SortOrder.Ascending)
        {
            Sorting.Add(new SortingInfo<TSortingEnum>() { SortBy = sortBy, SortOrder = sortOrder });
            return (TQuery)this;
        }
    }
}
