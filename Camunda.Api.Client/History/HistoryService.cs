namespace Camunda.Api.Client.History
{
    public class HistoryService
    {
        private CamundaClient.HistoricApi _api;

        internal HistoryService(CamundaClient.HistoricApi api)
        {
            _api = api;
        }

        /// <summary>
        /// Process Instance
        /// </summary>
        public HistoricProcessInstanceService ProcessInstances => new HistoricProcessInstanceService(_api.ProcessInstanceApi.Value);

        /// <summary>
        /// Activity Instance
        /// </summary>
        public HistoricActivityInstanceService ActivityInstances => new HistoricActivityInstanceService(_api.ActivityInstanceApi.Value);

        /// <summary>
        /// Job Log
        /// </summary>
        public HistoricJobLogService JobLogs => new HistoricJobLogService(_api.JobLogApi.Value);

        /// <summary>
        /// Incident
        /// </summary>
        public HistoricIncidentService Incidents => new HistoricIncidentService(_api.IncidentApi.Value);

        /// <summary>
        /// Variable Instance
        /// </summary>
        public HistoricVariableInstanceService VariableInstances => new HistoricVariableInstanceService(_api.VariableInstanceApi.Value);

        /// <summary>
        /// Detail
        /// </summary>
        public HistoricDetailService Detail => new HistoricDetailService(_api.DetailApi.Value);

    }
}
