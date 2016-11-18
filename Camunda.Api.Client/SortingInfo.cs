
using System;
using System.Collections.Generic;

namespace Camunda.Api.Client
{
    public class SortingInfo<TEnum> where TEnum: struct, IConvertible
    {
        /// <summary>
        /// Mandatory. Sort the results lexicographically by a given criterion.
        /// </summary>
        public TEnum SortBy;
        /// <summary>
        /// Mandatory. Sort the results in a given order. Values may be asc for ascending order or desc for descending order.
        /// </summary>
        public SortOrder SortOrder;

        public Dictionary<string, object> Parameters;

        public override string ToString() => SortBy.ToString() + " " + SortOrder;
    }
}
