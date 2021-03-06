using Newtonsoft.Json;
using System.Collections.Generic;

namespace Camunda.Api.Client.ExternalTask
{
    public class FetchExternalTaskTopic
    {
        /// <param name="topicName">The topic's name.</param>
        /// <param name="lockDuration">The duration to lock the external tasks for in milliseconds.</param>
        public FetchExternalTaskTopic(string topicName, long lockDuration)
        {
            TopicName = topicName;
            LockDuration = lockDuration;
        }

        /// <summary>
        ///  A String value which enables the filtering of tasks based on process instance business key.
        /// </summary>
        public string BusinessKey;

        /// <summary>
        /// Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on server side (default false).
        /// </summary>
        public bool DeserializeValues;

        /// <summary>
        /// If true only local variables will be fetched.
        /// </summary>
        public bool LocalVariables;

        /// <summary>
        /// The duration to lock the external tasks for in milliseconds.
        /// </summary>
        public long LockDuration;

        /// <summary>
        /// Filter tasks based on process definition id.
        /// </summary>
        public string ProcessDefinitionId;

        /// <summary>
        /// Filter tasks based on process definition ids.
        /// </summary>
        [JsonProperty("processDefinitionIdIn")]
        public List<string> ProcessDefinitionIds = new List<string>();

        /// <summary>
        /// Filter tasks based on process definition key.
        /// </summary>
        public string ProcessDefinitionKey;

        /// <summary>
        /// Filter tasks based on process definition keys.
        /// </summary>
        [JsonProperty("processDefinitionKeyIn")]
        public List<string> ProcessDefinitionKeys = new List<string>();

        /// <summary>
        /// A map of variables used for filtering tasks based on process instance variable values.
        /// </summary>
        public Dictionary<string, object> ProcessVariables = new Dictionary<string, object>();

        /// <summary>
        /// Filter tasks based on tenant ids.
        /// </summary>
        [JsonProperty("tenantIdIn")]
        public List<string> TenantIds = new List<string>();

        /// <summary>
        /// The topic's name
        /// </summary>
        public string TopicName;

        /// <summary>
        /// Array of String values that represent variable names.
        /// For each result task belonging to this topic, the given variables are returned as well if they are accessible from the external task's execution.
        /// </summary>
        public List<string> Variables;

        /// <summary>
        /// Filter tasks without tenant id.
        /// </summary>
        public bool WithoutTenantId;

        /// <summary>
        /// Include extension properties define in BMPN activity.
        /// </summary>
        public bool IncludeExtensionProperties;

        public override string ToString() => TopicName;
    }
}