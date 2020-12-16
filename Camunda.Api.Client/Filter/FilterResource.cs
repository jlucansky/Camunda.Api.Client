using Camunda.Api.Client.UserTask;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Camunda.Api.Client.Filter
{
    public class FilterResource
    {
        private IFilterRestService _api;
        private string _filterId;

        internal FilterResource(IFilterRestService api, string filterId)
        {
            _api = api;
            _filterId = filterId;
        }

        /// <summary>
        /// Retrieves a single filter by id.
        /// </summary>
        public Task<FilterInfo.Response> Get() => _api.Get(_filterId);

        /// <summary>
        /// Updates an existing filter.
        /// </summary>
        /// <param name="filterInfo"></param>
        /// <returns></returns>
        public Task Update(FilterInfo.Request filterInfo) => _api.Update(_filterId, filterInfo);

        /// <summary>
        /// Delete an existing filter.
        /// </summary>
        /// <returns></returns>
        public Task Delete() => _api.Delete(_filterId);

        /// <summary>
        /// Executes the saved query of the filter by id and returns the single result.
        /// </summary>
        /// <returns></returns>
        public Task<UserTaskInfo> Execute() => _api.Execute(_filterId);

        /// <summary>
        /// Executes the saved query of the filter by id and returns the result list.
        /// </summary>
        /// <param name="firstResult"></param>
        /// <param name="maxResults"></param>
        /// <returns></returns>
        public Task<List<UserTaskInfo>> ExecuteList(int firstResult, int maxResults, TaskQuery query = null) => _api.ExecuteList(_filterId, firstResult, maxResults, query);

        /// <summary>
        /// Executes the saved query of the filter by id and returns the count.
        /// </summary>
        /// <returns></returns>
        public async Task<int> ExecuteCount(TaskQuery query = null) => (await _api.ExecuteCount(_filterId, query)).Count;

        public override string ToString() => _filterId;
    }
}
