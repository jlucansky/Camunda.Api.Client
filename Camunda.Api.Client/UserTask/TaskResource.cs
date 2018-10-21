using Camunda.Api.Client.ProcessDefinition;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Camunda.Api.Client.UserTask
{
    public class TaskResource
    {
        private string _taskId;
        private IUserTaskRestService _api;

        internal TaskResource(IUserTaskRestService api, string taskId)
        {
            _api = api;
            _taskId = taskId;
        }

        public TaskIdentityLinkResource IdentityLink => new TaskIdentityLinkResource(_api, _taskId);
        public TaskCommentResource Comment => new TaskCommentResource(_api, _taskId);
        public TaskAttachmentResource Attachment => new TaskAttachmentResource(_api, _taskId);
        public VariableResource Variables => new VariableResource(_api, _taskId);
        public LocalVariableResource LocalVariables => new LocalVariableResource(_api, _taskId);

        /// <summary>
        /// Retrieves a single task by its id.
        /// </summary>
        public Task<UserTaskInfo> Get() => _api.Get(_taskId);

        /// <summary>
        /// Retrieves the form key for a task. The form key corresponds to the FormData#formKey property in the engine. 
        /// This key can be used to do task-specific form rendering in client applications. 
        /// Additionally, the context path of the containing process application is returned.
        /// </summary>
        public Task<FormInfo> GetForm() => _api.GetForm(_taskId);

        /// <summary>
        /// Complete a task and update process variables using a form submit.
        /// </summary>
        /// <remarks>
        ///  * If the task is in state PENDING - ie. has been delegated before, it is not completed but resolved. Otherwise it will be completed.
        ///  * If the task has Form Field Metadata defined, the process engine will perform backend validation for any form fields which have validators defined.
        /// </remarks>
        public Task SubmitForm(CompleteTask completeTask) => _api.SubmitFormTask(_taskId, completeTask);

        /// <summary>
        /// Retrieves the rendered form for a task. This method can be used for getting the HTML rendering of a Generated Task Form.
        /// </summary>
        public Task<string> GetRenderedForm() => _api.GetRenderedForm(_taskId);

        /// <summary>
        /// Claim a task for a specific user.
        /// </summary>
        /// <remarks>
        /// The difference with set a assignee is that here a check is performed to see if the task already has a user assigned to it.
        /// </remarks>
        public Task Claim(string userId) => _api.ClaimTask(_taskId, new UserInfo() { UserId = userId });

        /// <summary>
        /// Resets a task’s assignee. If successful, the task is not assigned to a user.
        /// </summary>
        public Task Unclaim() => _api.UnclaimTask(_taskId);

        /// <summary>
        /// Complete a task and update process variables.
        /// </summary>
        public Task Complete(CompleteTask completeTask) => _api.CompleteTask(_taskId, completeTask);

        /// <summary>
        /// Resolve a task and update execution variables.
        /// </summary>
        public Task Resolve(CompleteTask completeTask) => _api.ResolveTask(_taskId, completeTask);

        /// <summary>
        /// Delegate a task to another user.
        /// </summary>
        public Task Delegate(string delegatedUser) => _api.DelegateTask(_taskId, new UserInfo() { UserId = delegatedUser });

        /// <summary>
        /// Change the assignee of a task to a specific user.
        /// </summary>
        /// <remarks>
        /// The difference with claim a task is that this method does not check if the task already has a user assigned to it.
        /// </remarks>
        public Task SetAssignee(string userId) => _api.SetAssignee(_taskId, new UserInfo() { UserId = userId });

        /// <summary>
        /// Retrieves the form variables for a task. 
        /// The form variables take form data specified on the task into account. 
        /// If form fields are defined, the variable types and default values of the form fields are taken into account.
        /// </summary>
        /// <param name="variableNames">
        /// Allows restricting the list of requested variables to the variable names in the list. 
        /// It is best practice to restrict the list of variables to the variables actually required by the form in order to minimize fetching of data. 
        /// If the query parameter is ommitted all variables are fetched. If the query parameter contains non-existent variable names, the variable names are ignored.
        /// </param>
        public Task<Dictionary<string, VariableValue>> GetFormVariables(params string[] variableNames) => _api.GetFormVariables(_taskId, variableNames.Join());
        /// <summary>
        /// Retrieves the form variables for a task. 
        /// The form variables take form data specified on the task into account. 
        /// If form fields are defined, the variable types and default values of the form fields are taken into account.
        /// </summary>
        /// <param name="variableNames">
        /// Allows restricting the list of requested variables to the variable names in the list. 
        /// It is best practice to restrict the list of variables to the variables actually required by the form in order to minimize fetching of data. 
        /// If the query parameter is ommitted all variables are fetched. If the query parameter contains non-existent variable names, the variable names are ignored.
        /// </param>
        /// <param name="deserializeValues">Determines whether serializable variable values (typically variables that store custom Java objects) should be deserialized on server side.</param>
        public Task<Dictionary<string, VariableValue>> GetFormVariables(string[] variableNames, bool deserializeValues = true) => _api.GetFormVariables(_taskId, variableNames.Join(), deserializeValues);

        /// <summary>
        /// Updates a task.
        /// </summary>
        public Task Update(UserTask task) => _api.UpdateTask(_taskId, task);

        /// <summary>
        /// Delete a task.
        /// </summary>
        public Task Delete() => _api.DeleteTask(_taskId);

        public override string ToString() => _taskId;
    }
}
