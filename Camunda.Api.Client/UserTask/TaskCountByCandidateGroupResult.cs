namespace Camunda.Api.Client.UserTask
{
    public class TaskCountByCandidateGroupResult
    {
        /// <summary>
        /// The name of the candidate group. If there are tasks without a group name, the value will be <c>null</c>.
        /// </summary>
        public string GroupName;
        /// <summary>
        /// The number of tasks which have the group name as candidate group.
        /// </summary>
        public int TaskCount;

        public override string ToString()
        {
            if (string.IsNullOrEmpty(GroupName))
                return TaskCount.ToString();
            else
                return $"{GroupName}: {TaskCount}";
        }
    }
}
