using System.Collections.Generic;
using System.Threading.Tasks;

namespace Camunda.Api.Client.History
{
    public class HistoricUserOperationLogResource
    {
        private IHistoricUserOperationLogRestService _api;

        private string _userOperationId;


        internal HistoricUserOperationResource(IHistoricUserOperationLogRestService api, string userOperationId)
        {
            _api = api;
            _userOperationId = userOperationId;
        }

        /// <summary>
        /// Retrieves a single task by its id.
        /// </summary>
        public Task<HistoricUserOperationLog> Get() => _api.Get(_userOperationId);

        /// <summary>
         /// Set an annotation for auditing reasons.
         /// </summary>
         /// <param name="historicUserOperationLogAnnotation"></param>
         /// <returns></returns>
         public Task SetAnnotation(HistoricUserOperationLogAnnotation historicUserOperationLogAnnotation) => _api.SetAnnotation(_operationId, historicUserOperationLogAnnotation);


         /// <summary>
         /// Clear the annotation which was previously set for auditing reasons.
         /// </summary>
         /// <returns></returns>
         public Task ClearAnnotation() => _api.ClearAnnotation(_operationId);
   
    }
}
