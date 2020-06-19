#region Usings

using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

#endregion

namespace Camunda.Api.Client.CaseInstance
{
    public class CaseInstanceResource
    {
        private string _caseInstanceId;
        private ICaseInstanceRestService _api;

        internal CaseInstanceResource(ICaseInstanceRestService api, string caseInstanceId)
        {
            _api = api;
            _caseInstanceId = caseInstanceId;
        }

        /// <summary>
        /// Retrieves a case instance by id, according to the CaseInstance interface in the engine.
        /// </summary>
        /// <returns>corresponding case instance basis info</returns>
        public Task<CaseInstanceInfo> Get() => _api.Get(_caseInstanceId);

        /// <summary>
        /// Performs a transition from ACTIVE state to COMPLETED state. In relation to the state transition, it is possible to update or delete case instance variables (please note: deletion precedes update).
        /// </summary>
        /// <param name="completeCaseInstanceState">contains variables to delete or update</param>
        /// <returns></returns>
        public Task Complete(ChangeCaseInstanceState completeCaseInstanceState) =>
            _api.Complete(_caseInstanceId, completeCaseInstanceState);

        /// <summary>
        /// Performs a transition from COMPLETED state to CLOSED state. In relation to the state transition, it is possible to update or delete case instance variables (please note: deletion precedes update).
        /// </summary>
        /// <param name="closeCaseInstanceState">contains variables to delete or update</param>
        /// <returns></returns>
        public Task Close(ChangeCaseInstanceState closeCaseInstanceState) =>
            _api.Close(_caseInstanceId, closeCaseInstanceState);

        /// <summary>
        /// Performs a transition from ACTIVE state to TERMINATED state. In relation to the state transition, it is possible to update or delete case instance variables (please note: deletion precedes update).
        /// </summary>
        /// <param name="terminateCaseInstanceState">contains variables to delete or update</param>
        /// <returns></returns>
        public Task Terminate(ChangeCaseInstanceState terminateCaseInstanceState) =>
            _api.Terminate(_caseInstanceId, terminateCaseInstanceState);


        public VariableResource Variables => new VariableResource(_api, _caseInstanceId);

        public override string ToString() => _caseInstanceId;
    }
}
