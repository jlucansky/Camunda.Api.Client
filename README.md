# Maintained Fork of [[Camunda.Api.Client](https://github.com/jlucansky/Camunda.Api.Client)]
After [Jan Lucansky](https://github.com/jlucansky) stopped maintaining the orginal version we started maintaining our own fork.
It is a drop-in-replacement for the original version.
Just use Komsa.Camunda.Api.Client nuget package instead of Camunda.Api.Client.

# Camunda REST API Client [![Build status](https://ci.appveyor.com/api/projects/status/l2ct8th9hwuwlqvf?svg=true)](https://ci.appveyor.com/project/jlucansky/camunda-api-client) [![NuGet](https://img.shields.io/nuget/v/Camunda.Api.Client.svg)](https://www.nuget.org/packages/Camunda.Api.Client)
Camunda REST API Client for .NET platform
- [x] .NET Framework 4.6.1
- [x] .NET Standard 2.0

## Covered API
Each part listed below is fully covered according to https://docs.camunda.org/manual/latest/reference/rest specification.
- [x] [Case Definition](https://docs.camunda.org/manual/latest/reference/rest/case-definition/)
- [x] [Case Execution](https://docs.camunda.org/manual/latest/reference/rest/case-execution/)
- [x] [Case Instance](https://docs.camunda.org/manual/latest/reference/rest/case-instance/)
- [x] [Decision Definition](https://docs.camunda.org/manual/latest/reference/rest/decision-definition/)
- [x] [Decision Requirements Definition](https://docs.camunda.org/manual/latest/reference/rest/decision-requirements-definition/)
- [x] [Deployment](https://docs.camunda.org/manual/latest/reference/rest/deployment/)
- [x] [Execution](https://docs.camunda.org/manual/latest/reference/rest/execution/)
- [x] [External Task](https://docs.camunda.org/manual/latest/reference/rest/external-task/)
- [x] [Filter](https://docs.camunda.org/manual/latest/reference/rest/filter/)
- [x] [Group](https://docs.camunda.org/manual/latest/reference/rest/group/)
- [x] [History / Activity Instance](https://docs.camunda.org/manual/latest/reference/rest/history/activity-instance/)
- [x] [History / Case Definition](https://docs.camunda.org/manual/latest/reference/rest/history/case-definition/)
- [x] [History / Case Instance](https://docs.camunda.org/manual/latest/reference/rest/history/case-instance/)
- [x] [History / Case Activity Instance](https://docs.camunda.org/manual/latest/reference/rest/history/case-activity-instance/)
- [x] [History / Decision Instance](https://docs.camunda.org/manual/latest/reference/rest/history/decision-instance/)
- [x] [History / Decision Requirements Definition](https://docs.camunda.org/manual/latest/reference/rest/history/decision-requirements-definition/)
- [x] [History / Detail](https://docs.camunda.org/manual/latest/reference/rest/history/detail/)
- [x] [History / External Task Log](https://docs.camunda.org/manual/latest/reference/rest/history/external-task-log/)
- [x] [History / Incident](https://docs.camunda.org/manual/latest/reference/rest/history/incident/)
- [x] [History / Job Log](https://docs.camunda.org/manual/latest/reference/rest/history/job-log/)
- [x] [History / Process Definition](https://docs.camunda.org/manual/latest/reference/rest/history/process-definition/)
- [x] [History / Process Instance](https://docs.camunda.org/manual/latest/reference/rest/history/process-instance/)
- [x] [History / Task](https://docs.camunda.org/manual/latest/reference/rest/history/task/)
- [x] [History / Variable Instance](https://docs.camunda.org/manual/latest/reference/rest/history/variable-instance/)
- [x] [Incident](https://docs.camunda.org/manual/latest/reference/rest/incident/)
- [X] [Job](https://docs.camunda.org/manual/latest/reference/rest/job/)
- [x] [Job Definition](https://docs.camunda.org/manual/latest/reference/rest/job-definition/)
- [x] [Message](https://docs.camunda.org/manual/latest/reference/rest/message/)
- [x] [Migration](https://docs.camunda.org/manual/latest/reference/rest/migration/)
- [x] [Process Definition](https://docs.camunda.org/manual/latest/reference/rest/process-definition/)
- [x] [Process Instance](https://docs.camunda.org/manual/latest/reference/rest/process-instance/)
- [x] [Signal](https://docs.camunda.org/manual/latest/reference/rest/signal/)
- [x] [Task](https://docs.camunda.org/manual/latest/reference/rest/task/)
- [x] [Tenant](https://docs.camunda.org/manual/latest/reference/rest/tenant/)
- [x] [User](https://docs.camunda.org/manual/latest/reference/rest/user/)
- [x] [Variable Instance](https://docs.camunda.org/manual/latest/reference/rest/variable-instance/)

## Install
The Camunda REST API Client is available on [nuget.org](https://www.nuget.org/packages/Komsa.Camunda.Api.Client)

To install Camunda REST API Client, run the following command in the Package Manager Console
```
PM> Install-Package Komsa.Camunda.Api.Client
```

## Usage

#### Initialize client
```cs
CamundaClient camunda = CamundaClient.Create("http://localhost:8080/engine-rest");
```

#### Basic Authentication
```cs
HttpClient httpClient = new HttpClient();
httpClient.BaseAddress = new Uri("http://localhost:8080/engine-rest");
httpClient.DefaultRequestHeaders.Add("Authorization", "Basic ZGVtbzpkZW1v");
CamundaClient camunda = CamundaClient.Create(httpClient);
```

#### Filter external tasks
```cs
// build query
var externalTaskQuery = new ExternalTaskQuery() { Active = true, TopicName = "MyTask" };

// add some sorting
externalTaskQuery
    .Sort(ExternalTaskSorting.TaskPriority, SortOrder.Descending)
    .Sort(ExternalTaskSorting.LockExpirationTime);

// request external tasks according to query
List<ExternalTaskInfo> tasks = await camunda.ExternalTasks.Query(externalTaskQuery).List();
```
#### Get all external tasks
```cs
// get all external tasks without specifying query
List<ExternalTaskInfo> allTasks = await camunda.ExternalTasks.Query().List();
```
#### Set process variable
```cs
VariableResource vars = camunda.ProcessInstances["0ea218e8-9cfa-11e6-90a6-ac87a31e24fd"].Variables;

// set integer variable
await vars.Set("Var1", VariableValue.FromObject(123));

// set content of binary variable from file
await vars.SetBinary("DocVar", new BinaryDataContent(File.OpenRead("document.doc")), BinaryVariableType.Bytes);
```
#### Load typed variables
```cs
var executionId = "290a7fa2-8bc9-11e6-ab5b-ac87a31e24fd";
// load all variables of specified execution
Dictionary<string, VariableValue> allVariables = await camunda.Executions[executionId]
    .LocalVariables.GetAll();

// obtain strongly typed variable with name Var1
int myVar1 = allVariables["Var1"].GetValue<int>();
```
#### Save content of variable to file
```cs
HttpContent fileContent = await camunda.Executions[executionId]
    .LocalVariables.GetBinary("file1");

using (fileContent)
{
    using (var outStream = File.OpenWrite("file1.doc"))
    {
        (await fileContent.ReadAsStreamAsync()).CopyTo(outStream);
    }
}
```
#### Message correlation
```cs
var msg = new CorrelationMessage() { All = true, MessageName = "TestMsg" };

msg.ProcessVariables
    .Set("Date", DateTime.Today)
    .Set("ComplexVar", new { abc = "xyz", num = 123});

// correlate message with process variables
await camunda.Messages.DeliverMessage(msg);
```
#### Deploy resources
```cs
// deploy new bpmn diagram with some attachment
await camunda.Deployments.Create("My Deployment 1",
    new ResourceDataContent(File.OpenRead("C:\\diagram.bpmn"), "diagram.bpmn"), 
    new ResourceDataContent(File.OpenRead("C:\\document.doc"), "document.doc"));
```
#### Conditional query
```cs
// get all jobs owned by Process_1 with DueDate in the future
var jobQuery = new JobQuery() { ProcessDefinitionKey = "Process_1" };
jobQuery.DueDates.Add(new ConditionQueryParameter() 
{
    Operator = ConditionOperator.GreaterThan, Value = DateTime.Now
});

var jobs = await camunda.Jobs.Query(jobQuery).List();
```

## License
This project is made available under the MIT license. See [LICENSE](LICENSE) for details.
