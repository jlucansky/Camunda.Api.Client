using System;

namespace Camunda.Api.Client.History
{
    public class HistoricTaskCountReport : AbstractReport
    {
        /// <summary>
        /// Restrict to tasks that were completed before the given date. By default*, the date must have the format yyyy-MM-dd'T'HH:mm:ss.SSSZ, e.g., 2013-01-23T14:42:45.000+0200.
        /// </summary>
        public DateTime? CompletedAfter;

        /// <summary>
        ///Restrict to tasks that were completed before the given date. By default*, the date must have the format yyyy-MM-dd'T'HH:mm:ss.SSSZ, e.g., 2013-01-23T14:42:45.000+0200.
        /// </summary>
        public DateTime? CompletedBefore;

        /// <summary>
        /// When the report type is set to count, this parameter is Mandatory. Groups the tasks report by a given criterion. Valid values are taskName and processDefinition.
        /// </summary>
        public GroupBy GroupBy;

        public HistoricTaskCountReport()
        {
            ReportType = ReportType.Count;
        }
    }
}
