using System.Collections.Generic;
using System.Threading.Tasks;

namespace Camunda.Api.Client.History
{
    public class HistoricCaseActivityInstanceQueryResource
    {
        private IHistoricCaseActivityInstanceRestService _api;
        private HistoricCaseActivityInstanceQuery _query;

        internal HistoricCaseActivityInstanceQueryResource(IHistoricCaseActivityInstanceRestService api, HistoricCaseActivityInstanceQuery query)
        {
            _api = api;
            _query = query;
        }

        /// <summary>
        /// Query for variable instances that fulfill given parameters.
        /// </summary>
        public Task<List<HistoricCaseActivityInstance>> List() => _api.GetList(_query.CaseInstanceId, null, null);

        /// <summary>
        /// Query for variable instances that fulfill given parameters.
        /// </summary>
        /// <param name="firstResult">Pagination of results. Specifies the index of the first result to return.</param>
        /// <param name="maxResults">Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left.</param>
        public Task<List<HistoricCaseActivityInstance>> List(int firstResult, int maxResults) => _api.GetList(_query.CaseInstanceId, firstResult, maxResults);

        // TODO: Count
    }
}