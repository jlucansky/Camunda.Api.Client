namespace Camunda.Api.Client.History
{
    public class DurationReportResult : ReportResult
    {
        /// <summary>
        /// The smallest duration in milliseconds of all completed process instances which were started in the given period.
        /// </summary>
        public long Minimum;
        /// <summary>
        /// The greatest duration in milliseconds of all completed process instances which were started in the given period.
        /// </summary>
        public long Maximum;
        /// <summary>
        /// The average duration in milliseconds of all completed process instances which were started in the given period.
        /// </summary>
        public long Average;
    }
}
