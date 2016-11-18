using System;

namespace Camunda.Api.Client.Execution
{
    public class EventSubscription
    {
        /// <summary>
        /// The identifier of the event subscription.
        /// </summary>
        public string Id;
        /// <summary>
        /// The type of the event. message for message events.
        /// </summary>
        public string EventType;
        /// <summary>
        /// The name of the event the subscription belongs to, as defined in the process model.
        /// </summary>
        public string EventName;
        /// <summary>
        /// The id of the execution the subscription belongs to.
        /// </summary>
        public string ExecutionId;
        /// <summary>
        /// The id of the process instance the subscription belongs to.
        /// </summary>
        public string ProcessInstanceId;
        /// <summary>
        /// The id of the activity that the event subscription belongs to. Corresponds to the id in the process model.
        /// </summary>
        public string ActivityId;
        /// <summary>
        /// The time the subscription was created by the engine.
        /// </summary>
        public DateTime CreatedDate;
        /// <summary>
        /// The id of the tenant the subscription belongs to.
        /// </summary>
        public string TenantId;

        public override string ToString() => Id;
    }
}
