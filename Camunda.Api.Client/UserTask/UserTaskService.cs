﻿using System.Collections.Generic;
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

        public QueryResource<TaskQuery, UserTaskInfo> Query(TaskQuery query = null) =>
            new QueryResource<TaskQuery, UserTaskInfo>(query, _api.GetList, _api.GetListCount);

        public Task Create(UserTask task) => _api.CreateTask(task);
    }
}
