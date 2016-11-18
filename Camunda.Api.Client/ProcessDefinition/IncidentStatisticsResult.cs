
namespace Camunda.Api.Client.ProcessDefinition
{
    public class IncidentStatisticsResult
    {
        /// <summary>
        /// The type of the incident the number of incidents is aggregated for.
        /// </summary>
        public string IncidentType;
        /// <summary>
        /// The total number of incidents for the corresponding incident type.
        /// </summary>
        public int IncidentCount;

        public override string ToString() => $"{IncidentType} ({IncidentCount})";
    }
}
