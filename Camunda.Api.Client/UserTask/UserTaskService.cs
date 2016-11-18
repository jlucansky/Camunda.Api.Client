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

        public Task Create(UserTask task) => _api.CreateTask(task);
    }
}
