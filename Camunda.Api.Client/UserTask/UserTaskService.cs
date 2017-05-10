using System.Collections.Generic;
using System.Threading.Tasks;

namespace Camunda.Api.Client.UserTask
{
    public class UserTaskService
    {
        private IUserTaskRestService _api;

        internal UserTaskService(IUserTaskRestService api)
        {
            _api = api;
        }

        public TaskResource this[string taskId] => new TaskResource(_api, taskId);

        /// <summary>
        /// Retrieves the number of tasks for each candidate group.
        /// </summary>
        public Task<List<TaskCountByCandidateGroupResult>> GetTaskCountByCandidateGroup() => _api.GetTaskCountByCandidateGroup();

        public QueryResource<TaskQuery, UserTaskInfo> Query(TaskQuery query = null)
            => new QueryResource<TaskQuery, UserTaskInfo>(_api, query);

        /// <summary>
        /// Creates a new (user) task.
        /// </summary>
        public Task Create(UserTask task) => _api.CreateTask(task);

        /// <summary>
        /// Retrieves a task by id.
        /// </summary>
        public Task<UserTaskInfo> Get(string id) => _api.Get(id);

        /// <summary>
        /// Claims a task for a specific user.
        /// Note: The difference with the Set Assignee method is that here a check is performed to see if the task already has a user assigned to it.
        /// </summary>
        public Task Claim(string id, UserInfo userinfo) => _api.ClaimTask(id, userinfo);

        /// <summary>
        /// Resets a task’s assignee. If successful, the task is not assigned to a user.
        /// </summary>
        public Task Unclaim(string id) => _api.UnclaimTask(id);

        /// <summary>
        /// Completes a task and updates process variables.
        /// </summary>
        public Task Complete(string id, CompleteTask completeTask) => _api.CompleteTask(id, completeTask);

        /// <summary>
        /// Completes a task and updates process variables using a form submit. There are two difference between this method and the complete method:
        /// - If the task is in state PENDING - i.e., has been delegated before, it is not completed but resolved.Otherwise it will be completed.
        /// - If the task has Form Field Metadata defined, the process engine will perform backend validation for any form fields which have validators defined.See the Generated Task Forms section of the User Guide for more information.
        /// </summary>
        public Task SubmitForm(string id, CompleteTask completeTask) => _api.SubmitFormTask(id, completeTask);


        /// <summary>
        /// Resolves a task and updates execution variables.
        /// </summary>
        public Task ResolveTask(string id, CompleteTask completeTask) => _api.ResolveTask(id, completeTask);

        /// <summary>
        /// Changes the assignee of a task to a specific user.
        /// Note: The difference with the Claim Task method is that this method does not check if the task already has a user assigned to it.
        /// </summary>
        public Task SetAssignee(string id, UserInfo user) => _api.SetAssignee(id, user);

        /// <summary>
        /// Delegates a task to another user.
        /// </summary>
        public Task Delegate(string id, UserInfo user) => _api.DelegateTask(id, user);

        /// <summary>
        /// Retrieves the rendered form for a task. This method can be used to get the HTML rendering of a Generated Task Form.
        /// </summary>
        public Task<string> GetRenderedForm(string id) => _api.GetRenderedForm(id);

        /// <summary>
        /// Retrieves the form variables for a task. The form variables take form data specified on the task into account. If form fields are defined, the variable types and default values of the form fields are taken into account.
        /// </summary>
        public Task<Dictionary<string, VariableValue>> GetFormVariables(string id, string variableNames, bool deserializeValues = true) => _api.GetFormVariables(id, variableNames, deserializeValues);

        /// <summary>
        /// Updates a task.
        /// </summary>
        public Task Update(string id, UserTask task) => _api.UpdateTask(id, task);

    }
}
