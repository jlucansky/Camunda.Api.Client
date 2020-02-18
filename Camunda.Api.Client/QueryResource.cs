using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Camunda.Api.Client
{
    public class QueryResource<TQuery, TResult> where TQuery: new()
    {
        private readonly TQuery _query;
        private readonly Func<TQuery, int?, int?, Task<List<TResult>>> _getList;
        private readonly Func<TQuery, Task<CountResult>> _getCount;

        internal QueryResource(TQuery query, Func<TQuery, int?, int?, Task<List<TResult>>> getList, Func<TQuery, Task<CountResult>> getCount)
        {
            _query = query == null ? new TQuery() : query;
            _getList = getList ?? throw new ArgumentNullException(nameof(getList));
            _getCount = getCount ?? throw new ArgumentNullException(nameof(getCount));
        }

        /// <summary>
        /// Query for items that fulfill given parameters.
        /// </summary>
        public Task<List<TResult>> List() => _getList(_query, null, null);

        /// <summary>
        /// Query for items that fulfill given parameters.
        /// </summary>
        /// <param name="firstResult">Pagination of results. Specifies the index of the first result to return.</param>
        /// <param name="maxResults">Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left.</param>
        public Task<List<TResult>> List(int firstResult, int maxResults) => _getList(_query, firstResult, maxResults);

        /// <summary>
        /// Get number of items that fulfill given parameters.
        /// </summary>
        /// <returns></returns>
        public async Task<int> Count() => (await _getCount(_query)).Count;
    }
}
