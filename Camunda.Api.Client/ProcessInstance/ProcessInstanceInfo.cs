
namespace Camunda.Api.Client.ProcessInstance
{
    public class ProcessInstanceInfo
    {
        /// <summary>
        /// The id of the process instance.
        /// </summary>
        public string Id;
        /// <summary>
        /// The id of the process definition this instance belongs to.
        /// </summary>
        public string DefinitionId;
        /// <summary>
        /// The business key of the process instance.
        /// </summary>
        public string BusinessKey;
        /// <summary>
        /// The id of the case instance associated with the process instance.
        /// </summary>
        public string CaseInstanceId;
        /// <summary>
        /// A flag indicating whether the process instance has ended or not. Deprecated: will always be false!
        /// </summary>
        public bool Ended;
        /// <summary>
        /// A flag indicating whether the process instance is suspended or not.
        /// </summary>
        public bool Suspended;
        /// <summary>
        /// The tenant id of the process instance.
        /// </summary>
        public string TenantId;

        public override string ToString() => Id;
    }
}
