using System.Runtime.Serialization;

namespace Camunda.Api.Client
{
    public enum SortOrder
    {
        /// <summary>
        /// Ascending order
        /// </summary>
        [EnumMember(Value = "asc")]
        Ascending,

        /// <summary>
        /// Descending order
        /// </summary>
        [EnumMember(Value = "desc")]
        Descending
    }
}
