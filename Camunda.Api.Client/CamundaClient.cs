using System;
using System.Net.Http;
using System.Reflection;
using System.Globalization;

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Refit;

using Camunda.Api.Client.CaseDefinition;
using Camunda.Api.Client.CaseExecution;
using Camunda.Api.Client.DecisionDefinition;
using Camunda.Api.Client.Deployment;
using Camunda.Api.Client.Execution;
using Camunda.Api.Client.ExternalTask;
using Camunda.Api.Client.ProcessDefinition;
using Camunda.Api.Client.ProcessInstance;
using Camunda.Api.Client.UserTask;
using Camunda.Api.Client.VariableInstance;
using Camunda.Api.Client.Message;
using Camunda.Api.Client.JobDefinition;
using Camunda.Api.Client.Job;
using Camunda.Api.Client.Incident;
using Camunda.Api.Client.History;
using Camunda.Api.Client.User;
using Camunda.Api.Client.Tenant;

using System.Net.Http;
using System.Reflection;

namespace Camunda.Api.Client
{
    public class CamundaClient
    {
        private Lazy<ICaseDefinitionRestService> _caseDefinitionRestService;
        private Lazy<ICaseExecutionRestService> _caseExecutionRestService;
        private Lazy<IDecisionDefinitionRestService> _decisionDefinitionRestService;
        private Lazy<IExternalTaskRestService> _externalTaskApi;
        private Lazy<IProcessInstanceRestService> _processInstanceApi;
        private Lazy<IVariableInstanceRestService> _variableInstanceApi;
        private Lazy<IProcessDefinitionRestService> _processDefinitionApi;
        private Lazy<IDeploymentRestService> _deploymentApi;
        private Lazy<IUserTaskRestService> _userTaskApi;
        private Lazy<IExecutionRestService> _executionApi;
        private Lazy<IMessageRestService> _messageApi;
        private Lazy<IJobDefinitionRestService> _jobDefinitionApi;
        private Lazy<IJobRestService> _jobApi;
        private Lazy<IIncidentRestService> _incidentApi;
        private Lazy<ITenantRestService> _tenantApi;
        private Lazy<IUserRestService> _userApi;
		private Lazy<IGroupRestService> _groupApi;

		private HistoricApi _historicApi;

        private string _hostUrl;
        private HttpClient _httpClient;

        private RefitSettings _refitSettings;
        private static JsonSerializerSettings _jsonSerializerSettings;
        private HttpMessageHandler _httpMessageHandler;

        internal static JsonSerializerSettings JsonSerializerSettings => _jsonSerializerSettings;

        internal class HistoricApi
        {
            public Lazy<IHistoricCaseDefinitionRestService> CaseDefinitionApi;
            public Lazy<IHistoricCaseInstanceRestService> CaseInstanceApi;
            public Lazy<IHistoricCaseActivityInstanceRestService> CaseActivityInstanceApi;
            public Lazy<IHistoricDecisionInstanceRestService> DecisionInstanceApi;
            public Lazy<IHistoricProcessInstanceRestService> ProcessInstanceApi;
            public Lazy<IHistoricActivityInstanceRestService> ActivityInstanceApi;
            public Lazy<IHistoricJobLogRestService> JobLogApi;
            public Lazy<IHistoricIncidentRestService> IncidentApi;
            public Lazy<IHistoricVariableInstanceRestService> VariableInstanceApi;
            public Lazy<IHistoricDetailRestService> DetailApi;
        }

        static CamundaClient()
        {

            _jsonSerializerSettings = _jsonSerializerSettings ?? new JsonSerializerSettings
            {
                ContractResolver = new CustomCamelCasePropertyNamesContractResolver(),
                NullValueHandling = NullValueHandling.Ignore, // not send empty fields
            };

            _jsonSerializerSettings.Converters.Add(new StringEnumConverter());
        }

        private void Initialize()
        {
            _httpMessageHandler = _httpMessageHandler ?? new ErrorMessageHandler();

            _refitSettings = _refitSettings ?? new RefitSettings
            {
                JsonSerializerSettings = _jsonSerializerSettings,
                HttpMessageHandlerFactory = () => _httpMessageHandler,
                UrlParameterFormatter = new CustomUrlParameterFormatter(),
            };
        }

        private class CustomUrlParameterFormatter : DefaultUrlParameterFormatter
        {
            public override string Format(object parameterValue, ParameterInfo parameterInfo)
            {
                if (parameterValue is bool)
                    return string.Format(CultureInfo.InvariantCulture, "{0}", parameterValue).ToLower();
                else
                    return base.Format(parameterValue, parameterInfo);
            }
        }

        private class CustomCamelCasePropertyNamesContractResolver : CamelCasePropertyNamesContractResolver
        {
            // preserve exact dictionary key
            protected override string ResolveDictionaryKey(string dictionaryKey) => dictionaryKey;
        }

        private class CustomUrlParameterFormatter : DefaultUrlParameterFormatter
        {
            public override string Format(object value, ParameterInfo parameterInfo)
            {
                // Lower-case booleans
                if (value != null && value is bool asBool) return value.ToString().ToLower();

                return base.Format(value, parameterInfo);
            }
        }

        private CamundaClient(string hostUrl)
        {
            _hostUrl = hostUrl;
            Initialize();
            CreateServices();
        }

        private CamundaClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
            Initialize();
            CreateServices();
        }

        private CamundaClient(string hostUrl, HttpMessageHandler httpMessageHandler)
        {
            _hostUrl = hostUrl;
            _httpMessageHandler = httpMessageHandler;
            Initialize();
            CreateServices();
        }

        private void CreateServices()
        {
            _caseDefinitionRestService = CreateService<ICaseDefinitionRestService>();
            _caseExecutionRestService = CreateService<ICaseExecutionRestService>();
            _decisionDefinitionRestService = CreateService<IDecisionDefinitionRestService>();
            _userApi = CreateService<IUserRestService>();
            _externalTaskApi = CreateService<IExternalTaskRestService>();
            _processInstanceApi = CreateService<IProcessInstanceRestService>();
            _variableInstanceApi = CreateService<IVariableInstanceRestService>();
            _processDefinitionApi = CreateService<IProcessDefinitionRestService>();
            _deploymentApi = CreateService<IDeploymentRestService>();
            _tenantApi = CreateService<ITenantRestService>();
            _userTaskApi = CreateService<IUserTaskRestService>();
            _executionApi = CreateService<IExecutionRestService>();
            _messageApi = CreateService<IMessageRestService>();
            _jobDefinitionApi = CreateService<IJobDefinitionRestService>();
            _jobApi = CreateService<IJobRestService>();
            _incidentApi = CreateService<IIncidentRestService>();
			_groupApi = CreateService<IGroupRestService>();

			_historicApi = new HistoricApi()
            {
                CaseDefinitionApi = CreateService<IHistoricCaseDefinitionRestService>(),
                CaseInstanceApi = CreateService<IHistoricCaseInstanceRestService>(),
                CaseActivityInstanceApi = CreateService<IHistoricCaseActivityInstanceRestService>(),
                DecisionInstanceApi = CreateService<IHistoricDecisionInstanceRestService>(),
                ProcessInstanceApi = CreateService<IHistoricProcessInstanceRestService>(),
                ActivityInstanceApi = CreateService<IHistoricActivityInstanceRestService>(),
                JobLogApi = CreateService<IHistoricJobLogRestService>(),
                IncidentApi = CreateService<IHistoricIncidentRestService>(),
                VariableInstanceApi = CreateService<IHistoricVariableInstanceRestService>(),
                DetailApi = CreateService<IHistoricDetailRestService>(),
            };
        }

        private Lazy<I> CreateService<I>()
        {
            if (_httpClient != null)
                return new Lazy<I>(() => RestService.For<I>(_httpClient, _refitSettings));
            else
                return new Lazy<I>(() => RestService.For<I>(_hostUrl, _refitSettings));
        }

        public static CamundaClient Create(string hostUrl)
        {
            return new CamundaClient(hostUrl);
        }

        public static CamundaClient Create(string hostUrl, HttpMessageHandler httpMessageHandler)
        {
            return new CamundaClient(hostUrl, httpMessageHandler);
        }

        public static CamundaClient Create(HttpClient httpClient)
        {
            return new CamundaClient(httpClient);
        }


        /// <see href="https://docs.camunda.org/manual/7.6/reference/rest/user/"/>
        public UserService Users => new UserService(_userApi.Value);

        /// <see href="https://docs.camunda.org/manual/7.6/reference/rest/case-definition/"/>
        public CaseDefinitionService CaseDefinitions => new CaseDefinitionService(_caseDefinitionRestService.Value);

        /// <see href="https://docs.camunda.org/manual/7.6/reference/rest/case-execution/"/>
        public CaseExecutionService CaseExecutions => new CaseExecutionService(_caseExecutionRestService.Value);

        /// <see href="https://docs.camunda.org/manual/7.6/reference/rest/decision-definition/"/>
        public DecisionDefinitionService DecisionDefinitions => new DecisionDefinitionService(_decisionDefinitionRestService.Value);

        /// <see href="https://docs.camunda.org/manual/7.6/reference/rest/external-task/"/>
        public ExternalTaskService ExternalTasks => new ExternalTaskService(_externalTaskApi.Value);

        /// <see href="https://docs.camunda.org/manual/7.6/reference/rest/process-instance/"/>
        public ProcessInstanceService ProcessInstances => new ProcessInstanceService(_processInstanceApi.Value);

        /// <see href="https://docs.camunda.org/manual/7.6/reference/rest/variable-instance/"/>
        public VariableInstanceService VariableInstances => new VariableInstanceService(_variableInstanceApi.Value);

        /// <see href="https://docs.camunda.org/manual/7.6/reference/rest/process-definition/"/>
        public ProcessDefinitionService ProcessDefinitions => new ProcessDefinitionService(_processDefinitionApi.Value);

        /// <see href="https://docs.camunda.org/manual/7.6/reference/rest/deployment/"/>
        public DeploymentService Deployments => new DeploymentService(_deploymentApi.Value);

        /// <see href="https://docs.camunda.org/manual/7.6/reference/rest/task/"/>
        public UserTaskService UserTasks => new UserTaskService(_userTaskApi.Value);

        /// <see href="https://docs.camunda.org/manual/7.6/reference/rest/execution/"/>
        public ExecutionService Executions => new ExecutionService(_executionApi.Value);

        /// <see href="https://docs.camunda.org/manual/7.6/reference/rest/message/"/>
        public MessageService Messages => new MessageService(_messageApi.Value);

        /// <see href="https://docs.camunda.org/manual/7.6/reference/rest/job-definition/"/>
        public JobDefinitionService JobDefinitions => new JobDefinitionService(_jobDefinitionApi.Value);

        /// <see href="https://docs.camunda.org/manual/7.6/reference/rest/job/"/>
        public JobService Jobs => new JobService(_jobApi.Value);

        /// <see href="https://docs.camunda.org/manual/7.6/reference/rest/incident/"/>
        public IncidentService Incidents => new IncidentService(_incidentApi.Value);

        /// <see href="https://docs.camunda.org/manual/7.6/reference/rest/history/"/>
        public HistoryService History => new HistoryService(_historicApi);

		/// <see href="https://docs.camunda.org/manual/7.6/reference/rest/group/"/>
		public GroupService Group => new GroupService(_groupApi.Value);

        /// <see href="https://docs.camunda.org/manual/7.6/reference/rest/tenant/"/>
        public TenantService Tenants => new TenantService(_tenantApi.Value);
    }
}
