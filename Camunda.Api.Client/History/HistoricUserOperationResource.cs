using System.Collections.Generic;
using System.Threading.Tasks;

namespace Camunda.Api.Client.History
{
    public class HistoricUserOperationResource
    {
        private IHistoricUserOperationRestService _api;

        private string _userOperationId;


        internal HistoricUserOperationResource(IHistoricUserOperationRestService api, string userOperationId)
        {
            _api = api;
            _userOperationId = userOperationId;
        }

        /// <summary>
        /// Retrieves a single task by its id.
        /// </summary>
        public Task<HistoricUserOperation> Get() => _api.Get(_userOperationId);


   
    }
}
