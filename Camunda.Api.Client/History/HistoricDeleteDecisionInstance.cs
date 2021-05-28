using System;
using System.Collections.Generic;
using System.Text;

namespace Camunda.Api.Client.History
{
    public class HistoricDeleteDecisionInstance
    {
        /// <summary>
        ///  A list historic decision instance ids to delete.
        /// </summary>
        public List<string> HistoricDecisionInstanceIds;

        /// <summary>
        /// A historic decision instance query like the request body described by POST /history/decision-instance .
        /// </summary>
        public HistoricDecisionInstanceQuery Query;

        /// <summary>
        /// A string with delete reason.
        /// </summary>
        public string DeleteReason;
    }
}
