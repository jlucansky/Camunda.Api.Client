namespace Camunda.Api.Client.History
{
    public class HistoricCaseDefinitionStatisticsResult
    {
        public string Id;

        public int Active;

        public int Available;

        public int Completed;

        public int Disabled;

        public int Enabled;

        public int Terminated;

        public override string ToString() => Id;
    }
}