using System.Collections.Generic;

namespace Camunda.Api.Client.Signal
{
    public class Signal
    {
        /// <summary>
        /// The name of the signal to deliver.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Optionally specifies a single execution which is notified by the signal.
        /// </summary>
        public string ExecutionId { get; set; }

        /// <summary>
        /// A JSON object containing variable key-value pairs. Each key is a variable name and each value a JSON variable value object.
        /// </summary>
        public Dictionary<string, VariableValue> Variables { get; set; }

        /// <summary>
        /// Specifies a tenant to deliver the signal. The signal can only be received on executions or process definitions which belongs to the given tenant.
        /// </summary>
        public string TenantId { get; set; }

        /// <summary>
        /// If true the signal can only be received on executions or process definitions which belongs to no tenant. Value may not be false as this is the default behavior.
        /// </summary>
        public bool WithoutTenantId { get; set; }
    }
}