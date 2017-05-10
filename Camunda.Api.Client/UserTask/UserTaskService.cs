using System.Collections.Generic;
using System.Net.Http;
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


        #region Identity Link

        /// <summary>
        /// Gets the identity links for a task by id, which are the users and groups that are in some relation to it (including assignee and owner).
        /// </summary>
        public Task<List<IdentityLink>> GetIdentityLinks(string id, string type) => _api.GetIdentityLinks(id, type);

        /// <summary>
        /// Adds an identity link to a task by id. Can be used to link any user or group to a task and specify a relation.
        /// </summary>
        public Task AddIdentityLink(string id, IdentityLink identityLink) => _api.AddIdentityLink(id, identityLink);

        /// <summary>
        /// Removes an identity link from a task by id.
        /// </summary>
        public Task DeleteIdentityLink(string id, IdentityLink identityLink) => _api.DeleteIdentityLink(id, identityLink);

        #endregion

        #region Variables

        /// <summary>
        /// Removes a variable that is visible to a task. A variable is visible to a task if it is a local task variable or declared in a parent scope of the task. 
        /// See documentation on visiblity of variables.
        /// </summary>
        public Task DeleteVariable(string id, string varName) => _api.DeleteVariable(id, varName);

        /// <summary>
        /// Retrieves a variable from the context of a given task. The variable must be visible from the task. 
        /// It is visible from the task if it is a local task variable or declared in a parent scope of the task. 
        /// See documentation on visiblity of variables.
        /// </summary>
        public Task<VariableValue> GetVariable(string id, string varName, bool deserializeValue = true) => _api.GetVariable(id, varName, deserializeValue = true);

        /// <summary>
        /// Retrieves all variables visible from the task. A variable is visible from the task if it is a local task variable
        /// or declared in a parent scope of the task. See documentation on visiblity of variables.
        /// </summary>
        public Task<Dictionary<string, VariableValue>> GetVariables(string id, bool deserializeValues = true) => _api.GetVariables(id, deserializeValues = true);

        /// <summary>
        /// Retrieves a binary variable from the context of a given task. Applicable for byte array and file variables. The variable must be visible from the task. 
        /// It is visible from the task if it is a local task variable or declared in a parent scope of the task. See documentation on visiblity of variables
        /// </summary>
        public Task<HttpResponseMessage> GetBinaryVariable(string id, string varName) => _api.GetBinaryVariable(id, varName);

        /// <summary>
        /// Sets the serialized value for a binary variable or the binary value for a file variable visible from the task. 
        /// A variable is visible from the task if it is a local task variable or declared in a parent scope of the task. 
        /// See documentation on visiblity of variables.
        /// </summary>
        //public Task SetBinaryVariable(string id, string varName, BinaryDataContent data, ValueTypeContent valueType) => _api.SetBinaryVariable(id, varName, data, valueType);

        /// <summary>
        /// Updates or deletes the variables visible from the task. Updates precede deletions. So, if a variable is updated AND deleted, 
        /// the deletion overrides the update. A variable is visible from the task if it is a local task variable or declared in a parent scope of the task. 
        /// See documentation on visiblity of variables.
        /// </summary>
        public Task ModifyVariables(string id, PatchVariables patch) => _api.ModifyVariables(id, patch);

        /// <summary>
        /// Sets a visible from the task. A variable is visible from the task if it is a local task variable or declared in a parent scope of the task. 
        /// See documentation on visiblity of variables. If a variable visible from the task with the given name already exists, 
        /// it is overwritten. Otherwise, the variable is created in the top-most scope visible from the task.
        /// </summary>
        public Task PutVariable(string id, string varName, VariableValue variable) => _api.PutVariable(id, varName, variable);

        #endregion

        #region Local Variables

        /// <summary>
        /// Removes a local variable from a task by id.
        /// </summary>
        public Task DeleteLocalVariable(string id, string varName) => _api.DeleteLocalVariable(id, varName);

        /// <summary>
        /// Retrieves a variable from the context of a given task by id.
        /// </summary>
        public Task<VariableValue> GetLocalVariable(string id, string varName, bool deserializeValue = true) => _api.GetLocalVariable(id, varName, deserializeValue);

        /// <summary>
        /// Retrieves all variables of a given task by id.
        /// </summary>
        public Task<Dictionary<string, VariableValue>> GetLocalVariables(string id, bool deserializeValues = true) => _api.GetLocalVariables(id, deserializeValues);

        /// <summary>
        /// Retrieves a binary variable from the context of a given task by id. Applicable for byte array and file variables.
        /// </summary>
        public Task<HttpResponseMessage> GetBinaryLocalVariable(string id, string varName) => _api.GetBinaryLocalVariable(id, varName);

        /// <summary>
        /// Sets the serialized value for a binary variable or the binary value for a file variable.
        /// </summary>
        //public Task SetBinaryLocalVariable(string id, string varName, BinaryDataContent data, ValueTypeContent valueType) => _api.SetBinaryLocalVariable(id, varName, data, valueType);

        /// <summary>
        /// Updates or deletes the variables in the context of a task. Updates precede deletions. So, if a variable is updated AND deleted, the deletion overrides the update.
        /// </summary>
        public Task ModifyLocalVariables(string id, PatchVariables patch) => _api.ModifyLocalVariables(id, patch);

        /// <summary>
        /// Sets a variable in the context of a given task.
        /// </summary>
        public Task PutLocalVariable(string id, string varName, VariableValue variable) => _api.PutLocalVariable(id, varName, variable);

        #endregion

        #region Report

        /// <summary>
        /// Retrieves the number of tasks for each candidate group.
        /// </summary>
        public Task<List<TaskCountByCandidateGroupResult>> GetTaskCountByCandidateGroup() => _api.GetTaskCountByCandidateGroup();

        #endregion


    }
}
