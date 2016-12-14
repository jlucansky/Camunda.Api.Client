using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace Camunda.Api.Client.Message
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class CorrelationMessage
    {
        /// <summary>
        /// The name of the message to deliver.
        /// </summary>
        public string MessageName;
        /// <summary>
        /// Used for correlation of process instances that wait for incoming messages. Will only correlate to executions that belong to a process instance with the provided business key.
        /// </summary>
        public string BusinessKey = "";
        /// <summary>
        /// Used for correlation of process instances that wait for incoming messages. Has to be an object containing key-value pairs that are matched against process instance variables during correlation. 
        /// </summary>
        public Dictionary<string, VariableValue> CorrelationKeys = new Dictionary<string, VariableValue>();
        /// <summary>
        /// A map of variables that is injected into the triggered execution or process instance after the message has been delivered.
        /// </summary>
        public Dictionary<string, VariableValue> ProcessVariables = new Dictionary<string, VariableValue>();
        /// <summary>
        /// Used to correlate the message for a tenant with the given id. Will only correlate to executions and process definitions which belongs to the tenant.
        /// </summary>
        public string TenantId;
        /// <summary>
        /// A Boolean value that indicates whether the message should only be correlated to executions and process definitions which belongs to no tenant. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool WithoutTenantId;
        /// <summary>
        /// Used to correlate the message to the process instance with the given id. Must not be supplied in conjunction with a tenantId.
        /// </summary>
        public string ProcessInstanceId;
        /// <summary>
        /// A Boolean value that indicates whether the message should be correlated to exactly one entity or multiple entities.
        /// If the value is set to false the message will be correlated to exactly one entity (execution or process definition).
        /// If the value is set to true the message will be correlated to multiple executions and a process definition that can be instantiated by this message in one go.
        /// </summary>
        public bool All = false;
        /// <summary>
        /// A Boolean value that indicates whether the result of the correlation should be returned or not.
        /// If this property is set to true, there will be returned a list of message correlation result objects.
        /// Depending on the all property, there will be either one ore more returned results in the list.
        /// </summary>
        public bool ResultEnabled;

        public CorrelationMessage SetVariable(string name, object value)
        {
            ProcessVariables = (ProcessVariables ?? new Dictionary<string, VariableValue>()).Set(name, value);
            return this;
        }

    }
}
