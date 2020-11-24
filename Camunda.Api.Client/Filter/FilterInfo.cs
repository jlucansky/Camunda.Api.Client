using System;

namespace Camunda.Api.Client.Filter
{
    public class FilterInfo
    {
        public class Request
        {
            /// <summary>
            /// The resource type of the filter.
            /// </summary>
            public string ResourceType;

            /// <summary>
            /// The name of the filter.
            /// </summary>
            public string Name;

            /// <summary>
            /// The user id of the owner of the filter.
            /// </summary>
            public string Owner;

            /// <summary>
            /// The query of the filter as a JSON object.
            /// </summary>
            public object Query;

            /// <summary>
            /// The properties of a filter as a JSON object.
            /// </summary>
            public object Properties;
        }

        public class Response
        {
            /// <summary>
            ///  The id of the filter.
            /// </summary>
            public string Id;

            /// <summary>
            /// The resource type of the filter.
            /// </summary>
            public string ResourceType;

            /// <summary>
            /// The name of the filter.
            /// </summary>
            public string Name;

            /// <summary>
            /// The user id of the owner of the filter.
            /// </summary>
            public string Owner;

            /// <summary>
            /// The query of the filter as a JSON object.
            /// </summary>
            public object Query;

            /// <summary>
            /// The properties of a filter as a JSON object.
            /// </summary>
            public object Properties;

            /// <summary>
            /// The number of items matched by the filter itself.Note: Only exists if the query parameter itemCount was set to true
            /// </summary>
            public long? ItemCount;
        }
    }
}
