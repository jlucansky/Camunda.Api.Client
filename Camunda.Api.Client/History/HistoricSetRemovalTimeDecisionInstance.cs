using System;
using System.Collections.Generic;
using System.Text;

namespace Camunda.Api.Client.History
{
    public class HistoricSetRemovalTimeDecisionInstance
    {
        /// <summary>
        ///  The date for which the historic decision instances shall be removed.
        ///  Value my not be null.
        ///  Note: Cannot be set in conjunction with clearedRemovalTime or calculatedRemovalTime.
        /// </summary>
        public DateTime AbsoluteRemovalTime;

        /// <summary>
        ///  Sets the removal time to null. Value may only be true, as false is the default behavior.
        ///  Note: Cannot be set in conjunction with absoluteRemovalTime or calculatedRemovalTime.
        /// </summary>
        public bool ClearedRemovalTime;

        /// <summary>
        /// The removal time is calculated based on the engine's configuration settings.
        ///Value may only be true, as false is the default behavior.
        ///Note: Cannot be set in conjunction with absoluteRemovalTime or clearedRemovalTime.
        /// </summary>
        public bool CalculatedRemovalTime;

        /// <summary>
        /// Sets the removal time to all historic decision instances in the hierarchy.
        /// Value may only be true, as false is the default behavior.
        /// </summary>
        public bool Hierarchical;

        /// <summary>
        /// Query for the historic decision instances to set the removal time for.
        /// </summary>
        public HistoricDecisionInstanceQuery Query;

        /// <summary>
        ///  The ids of the historic decision instances to set the removal time for.
        /// </summary>
        public List<string> HistoricDecisionInstanceIds;
    }
}
