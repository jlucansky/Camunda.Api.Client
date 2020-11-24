using System.Linq;
using System.Threading.Tasks;

namespace Camunda.Api.Client.Filter
{
    public class FilterService
    {
        private IFilterRestService _api;

        internal FilterService(IFilterRestService api) { _api = api; }

        public FilterResource this[string filterId] => new FilterResource(_api, filterId);

        public QueryResource<FilterQuery, FilterInfo.Response> Query(FilterQuery query = null) =>
            new QueryResource<FilterQuery, FilterInfo.Response>(
                query,
                (q, f, m) => _api.GetList(q, f, m),
                q => _api.GetListCount(q));

        /// <summary>
        /// Creates a new filter.
        /// </summary>
        /// <param name="filterInfo"></param>
        /// <returns></returns>
        public Task<FilterInfo.Response> Create(FilterInfo.Request filterInfo) => _api.Create(filterInfo);
    }
}
