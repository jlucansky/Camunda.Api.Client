using System.Collections.Generic;
using System.Threading.Tasks;

namespace Camunda.Api.Client.VariableInstance
{
    public class VariableInstanceQueryResource
    {
        private IVariableInstanceRestService _api;
        private VariableInstanceQuery _query;

        internal VariableInstanceQueryResource(IVariableInstanceRestService api, VariableInstanceQuery query)
        {
            _api = api;
            _query = query;
        }

        /// <summary>
        /// Query for variable instances that fulfill given parameters.
        /// </summary>
        public Task<List<VariableInstanceInfo>> List() => _api.GetList(_query, null, null);

        /// <summary>
        /// Query for variable instances that fulfill given parameters.
        /// </summary>
        /// <param name="firstResult">Pagination of results. Specifies the index of the first result to return.</param>
        /// <param name="maxResults">Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left.</param>
        /// <param name="deserializeValues">Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on server side.</param>
        public Task<List<VariableInstanceInfo>> List(int firstResult, int maxResults, bool deserializeValues = true) => _api.GetList(_query, firstResult, maxResults, deserializeValues);

        /// <summary>
        /// Get number of variable instances that fulfill given parameters.
        /// </summary>
        /// <returns></returns>
        public async Task<int> Count() => (await _api.GetListCount(_query)).Count;

    }
}
