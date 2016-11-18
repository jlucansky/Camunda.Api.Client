using System.Collections.Generic;

namespace Camunda.Api.Client.ProcessInstance
{
    public class ActivityInstanceInfo
    {
        /// <summary>
        /// The id of the activity instance.
        /// </summary>
        public string Id;
        /// <summary>
        /// The id of the parent activity.
        /// </summary>
        public string ParentActivityInstanceId;
        /// <summary>
        /// The id of the activity.
        /// </summary>
        public string ActivityId;
        /// <summary>
        /// The name of the activity.
        /// </summary>
        public string ActivityName;
        /// <summary>
        /// The type of activity (corresponds to the XML element name in the BPMN 2.0, e.g. 'userTask').
        /// </summary>
        public string ActivityType;
        /// <summary>
        /// The id of the process instance this activity instance is part of.
        /// </summary>
        public string ProcessInstanceId;
        /// <summary>
        /// The id of the process definition.
        /// </summary>
        public string ProcessDefinitionId;
        /// <summary>
        /// A list of child activity instances.
        /// </summary>
        public List<ActivityInstanceInfo> ChildActivityInstances;
        /// <summary>
        /// A list of child transition instances. A transition instance represents an execution waiting in an asynchronous continuation.
        /// </summary>
        public List<TransitionInstanceInfo> ChildTransitionInstances;
        /// <summary>
        /// A list of execution ids.
        /// </summary>
        public List<string> ExecutionIds;

        public override string ToString() => Id;
    }
}
