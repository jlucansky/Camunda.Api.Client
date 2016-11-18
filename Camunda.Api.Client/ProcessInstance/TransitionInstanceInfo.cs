namespace Camunda.Api.Client.ProcessInstance
{
    public class TransitionInstanceInfo
    {
        /// <summary>
        /// The id of the transition instance.
        /// </summary>
        public string Id;
        /// <summary>
        /// The id of the parent activity.
        /// </summary>
        public string ParentActivityInstanceId;
        /// <summary>
        /// The id of the process instance.
        /// </summary>
        public string ProcessInstanceId;
        /// <summary>
        /// The id of the process definition.
        /// </summary>
        public string ProcessDefinitionId;
        /// <summary>
        /// The id of the activity that this instance enters (asyncBefore job) or leaves (asyncAfter job)
        /// </summary>
        public string ActivityId;
        /// <summary>
        /// The name of the activity that this instance enters (asyncBefore job) or leaves (asyncAfter job)
        /// </summary>
        public string ActivityName;
        /// <summary>
        /// The type of the activity that this instance enters (asyncBefore job) or leaves (asyncAfter job). Corresponds to the XML element name in the BPMN 2.0, e.g. 'userTask'.
        /// </summary>
        public string ActivityType;
        /// <summary>
        /// A list of execution ids.
        /// </summary>
        public string ExecutionId;

        public override string ToString() => Id;
    }
}
