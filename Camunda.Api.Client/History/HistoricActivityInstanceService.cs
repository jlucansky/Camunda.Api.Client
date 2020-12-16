namespace Camunda.Api.Client.History
{
    public class HistoricActivityInstanceService
    {
        private IHistoricActivityInstanceRestService _api;

        internal HistoricActivityInstanceService(IHistoricActivityInstanceRestService api)
        {
            _api = api;
        }

        public QueryResource<HistoricActivityInstanceQuery, HistoricActivityInstance> Query(
            HistoricActivityInstanceQuery query = null) =>
            new QueryResource<HistoricActivityInstanceQuery, HistoricActivityInstance>(query, _api.GetList, _api.GetListCount);

        /// <param name="activityInstanceId">The id of the historic activity instance to be retrieved.</param>
        public HistoricActivityInstanceResource this[string activityInstanceId] => new HistoricActivityInstanceResource(_api, activityInstanceId);
    }
}
