# Camunda REST API Client
Camunda REST API Client for .NET platform

## Covered API
Each listed part below is fully covered according to https://docs.camunda.org/manual/7.5/reference/rest specification.
- [x] [Deployment](https://docs.camunda.org/manual/7.5/reference/rest/deployment/)
- [x] [Execution](https://docs.camunda.org/manual/7.5/reference/rest/execution/)
- [x] [External Task](https://docs.camunda.org/manual/7.5/reference/rest/external-task/)
- [x] [Incident](https://docs.camunda.org/manual/7.5/reference/rest/incident/)
- [X] [Job](https://docs.camunda.org/manual/7.5/reference/rest/job/)
- [x] [Job Definition](https://docs.camunda.org/manual/7.5/reference/rest/job-definition/)
- [x] [Message](https://docs.camunda.org/manual/7.5/reference/rest/message/)
- [x] [Process Definition](https://docs.camunda.org/manual/7.5/reference/rest/process-definition/)
- [x] [Process Instance](https://docs.camunda.org/manual/7.5/reference/rest/process-instance/)
- [x] [Task](https://docs.camunda.org/manual/7.5/reference/rest/task/)
- [x] [Variable Instance](https://docs.camunda.org/manual/7.5/reference/rest/variable-instance/)

## Install
The Camunda REST API Client is available on [nuget.org](https://www.nuget.org/packages/Camunda.Api.Client)

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
