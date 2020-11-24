using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Camunda.Api.Client.Filter
{
    public class FilterQuery : QueryParameters
    {

        /// <summary>
        /// Filter by the id of the filter.
        /// </summary>
        public string FilterId;

        /// <summary>
        /// Filter by the resource type of the filter, e.g., Task.
        /// </summary>
        public string ResourceType;

        /// <summary>
        /// Filter by the name of the filter.
        /// </summary>
        public string Name;

        /// <summary>
        /// Filter by the name that the parameter is a substring of.
        /// </summary>
        public string NameLike;

        /// <summary>
        /// Filter by the user id of the owner of the filter.
        /// </summary>
        public string Owner;

        /// <summary>
        /// If set to true, each filter result will contain an itemCount property with the number of items matched by the filter itself.
        /// </summary>
        public bool ItemCount;

        /// <summary>
        /// Sort the results lexicographically by a given criterion. Must be used in conjunction with the <see cref="SortOrder"/> parameter.
        /// </summary>
        public FilterSorting SortBy;
        /// <summary>
        /// Sort the results in a given order. Must be used in conjunction with the <see cref="SortBy"/> parameter.
        /// </summary>
        public SortOrder SortOrder;
    }

    public enum FilterSorting
    {
        filterId, 
        firstName, 
        lastName, 
        email
    }
}
