using System.Collections.Generic;
using System.Threading.Tasks;

namespace Camunda.Api.Client
{
    public class QueryResource<TQuery, TResult> where TQuery: new()
    {
        private dynamic _api;
        private TQuery _query;

        internal QueryResource(object api, TQuery query)
        {
            _api = api;
            _query = query == null ? new TQuery() : query;
        }

        /// <summary>
        /// Query for items that fulfill given parameters.
        /// </summary>
        public Task<List<TResult>> List() => _api.GetList(_query, null, null);

        /// <summary>
        /// Query for items that fulfill given parameters.
        /// </summary>
        /// <param name="firstResult">Pagination of results. Specifies the index of the first result to return.</param>
        /// <param name="maxResults">Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left.</param>
        public Task<List<TResult>> List(int firstResult, int maxResults) => _api.GetList(_query, firstResult, maxResults);

        /// <summary>
        /// Get number of items that fulfill given parameters.
        /// </summary>
        /// <returns></returns>
        public async Task<int> Count() => (await _api.GetListCount(_query)).Count;
    }
}
