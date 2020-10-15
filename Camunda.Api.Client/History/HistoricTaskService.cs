using System;
using System.Collections.Generic;
using System.Text;

namespace Camunda.Api.Client.History
{
    public class HistoricTaskService
    {

        private IHistoricTaskRestService _api;

        internal HistoricTaskService(IHistoricTaskRestService api)
        {
            _api = api;
        }

        public QueryResource<HistoricTaskQuery, HistoricTask> Query(
            HistoricTaskQuery query = null) =>
            new QueryResource<HistoricTaskQuery, HistoricTask>(
                query,
                (q, f, m) => _api.GetList(q, f, m),
                q => _api.GetListCount(q));
    }
}
