namespace Camunda.Api.Client.History
{
    public class CleanableProcessInstanceReport: CleanableProcessInstanceReportCount
    {
        /// <summary>
        /// Sort the results by a given criterion. A valid value is activityId. Must be used in conjunction with the sortOrder parameter.
        /// </summary>
        public CleanableProcessInstanceReportSorting SortBy;

        /// <summary>
        /// Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter.
        /// </summary>
        public SortOrder SortOrder;

        /// <summary>
        /// Pagination of results. Specifies the index of the first result to return.
        /// </summary>
        public int? FirstResult;

        /// <summary>
        /// Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left.
        /// </summary>
        public int? MaxResults;
    }

    public enum CleanableProcessInstanceReportSorting
    {
        Finished
    }
}
