# Camunda REST API Client
Camunda REST API Client for .NET platform

## Covered API
Each listed domain is fully covered according to https://docs.camunda.org/manual/7.5/reference/rest specification.
- [x] Deployment
- [x] Execution
- [x] External Task
- [x] Incident
- [X] Job
- [x] Job Definition
- [x] Message
- [x] Process Definition
- [x] Process Instance
- [x] Task
- [x] Variable Instance

## Install
The Camunda REST API Client is available on nuget.org

To install Camunda REST API Client, run the following command in the Package Manager Console
```
PM> Install-Package Camunda.Api.Client
```

## Usage

#### Initialize client
```cs
CamundaClient camunda = CamundaClient.Create("http://localhost:8080/engine-rest");
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
#### Load typed variables
```cs
// load all variables of specified execution
Dictionary<string, VariableValue> allVariables = await camunda.Executions["290a7fa2-8bc9-11e6-ab5b-ac87a31e24fd"]
    .LocalVariables.GetAll();
// obtain strongly typed variable with name Var1
int myVar1 = allVariables["Var1"].GetValue<int>();
```
#### Save content of variable to file
```cs
HttpContent fileContent = await camunda.Executions["290a7fa2-8bc9-11e6-ab5b-ac87a31e24fd"]
    .LocalVariables.GetBinary("file1");

using (fileContent)
using (var outStream = File.OpenWrite("file1.doc"))
{
    (await fileContent.ReadAsStreamAsync()).CopyTo(outStream);
}
```
#### Message correlation
```cs
var msg = new CorrelationMessage() { All = true, MessageName = "TestMsg" };

msg.ProcessVariables
    .Set("Date", DateTime.Now)
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
    Operator = ConditionOperator.GreaterThan, Value = DateTime.Now.Date
});

var jobs = await camunda.Jobs.Query(jobQuery).List();
```

## License
This project is made available under the MIT license. See [LICENSE](LICENSE) for details.
