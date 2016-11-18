namespace Camunda.Api.Client.VariableInstance
{
    public class VariableInstanceService
    {
        private IVariableInstanceRestService _api;

        internal VariableInstanceService(IVariableInstanceRestService api) { _api = api; }

        /// <param name="variableInstanceId">The id of the variable instance.</param>
        public VariableInstanceResource this[string variableInstanceId] => new VariableInstanceResource(_api, variableInstanceId);

        public VariableInstanceQueryResource Query(VariableInstanceQuery query = null)
            => new VariableInstanceQueryResource(_api, query ?? new VariableInstanceQuery());

    }
}
