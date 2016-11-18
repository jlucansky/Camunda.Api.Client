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
        /// The topic's name
        /// </summary>
        public string TopicName;
        /// <summary>
        /// The duration to lock the external tasks for in milliseconds.
        /// </summary>
        public long LockDuration;
        /// <summary>
        /// Array of String values that represent variable names. 
        /// For each result task belonging to this topic, the given variables are returned as well if they are accessible from the external task's execution.
        /// </summary>
        public List<string> Variables;

        public override string ToString() => TopicName;
    }
}
