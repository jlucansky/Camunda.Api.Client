using Camunda.Api.Client.ProcessInstance;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Camunda.Api.Client.ProcessDefinition
{
    public abstract class ProcessDefinitionResource
    {
        /// <summary>
        /// Retrieves a single process definition according to the ProcessDefinition interface in the engine.
        /// </summary>
        public abstract Task<ProcessDefinitionInfo> Get();

        /// <summary>
        /// Retrieves the BPMN 2.0 XML of this process definition.
        /// </summary>
        public abstract Task<ProcessDefinitionDiagram> GetXml();

        /// <summary>
        /// Retrieves the diagram of a process definition.
        /// </summary>
        /// <returns>Retrieves the diagram of a process definition.</returns>
        public abstract Task<HttpContent> GetDiagram();

        /// <summary>
        /// Instantiates a given process definition. Process variables and business key may be supplied in the request body.
        /// </summary>
        public abstract Task<ProcessInstanceInfo> StartProcessInstance(StartProcessInstance parameters);

        /// <summary>
        /// Start a process instance using a set of process variables and the business key. 
        /// If the start event has Form Field Metadata defined, the process engine will perform backend validation for any form fields which have validators defined. 
        /// </summary>
        public abstract Task<ProcessInstanceInfo> SubmitForm(SubmitStartForm parameters);
        
        protected abstract Task<List<StatisticsResult>> GetActivityStatistics(bool includeFailedJobs, bool? includeIncidents, string includeIncidentsForType);

        /// <summary>
        /// Retrieves runtime statistics of a given process definition grouped by activities. These statistics include the number of running activity instances, optionally the number of failed jobs and also optionally the number of incidents either grouped by incident types or for a specific incident type.
        /// </summary>
        /// <param name="includeFailedJobs">Whether to include the number of failed jobs in the result or not.</param>
        /// <param name="includeIncidents">If this property has been set to true the result will include the corresponding number of incidents for each occurred incident type. If it is set to false, the incidents will not be included in the result.</param>
        public Task<List<StatisticsResult>> GetActivityStatistics(bool includeFailedJobs, bool includeIncidents) => GetActivityStatistics(includeFailedJobs, includeIncidents, null);
        /// <summary>
        /// Retrieves runtime statistics of a given process definition grouped by activities. These statistics include the number of running activity instances, optionally the number of failed jobs and also optionally the number of incidents either grouped by incident types or for a specific incident type.
        /// </summary>
        /// <param name="includeFailedJobs">Whether to include the number of failed jobs in the result or not.</param>
        /// <param name="includeIncidentsForType">If this property has been set with any incident type (i.e. a String value) the result will only include the number of incidents for the assigned incident type.</param>
        public Task<List<StatisticsResult>> GetActivityStatistics(bool includeFailedJobs, string includeIncidentsForType) => GetActivityStatistics(includeFailedJobs, null, includeIncidentsForType);
        /// <summary>
        /// Retrieves runtime statistics of a given process definition grouped by activities. These statistics include the number of running activity instances, optionally the number of failed jobs and also optionally the number of incidents either grouped by incident types or for a specific incident type.
        /// </summary>
        /// <param name="includeFailedJobs">Whether to include the number of failed jobs in the result or not.</param>
        public Task<List<StatisticsResult>> GetActivityStatistics(bool includeFailedJobs) => GetActivityStatistics(includeFailedJobs, false, null);

        /// <summary>
        /// Retrieves the key of the start form for a process definition. The form key corresponds to the FormData#formKey property in the engine.
        /// </summary>
        public abstract Task<FormInfo> GetStartForm();

        /// <summary>
        /// Retrieves the rendered form for a process definition. This method can be used for getting the HTML rendering of a Generated Task Form.
        /// </summary>
        public abstract Task<string> GetRenderedForm();

        /// <summary>
        /// Activate or suspend a given process definition by id or by latest version of process definition key.
        /// </summary>
        public abstract Task UpdateSuspensionState(ProcessDefinitionSuspensionState state);

        /// <summary>
        /// Retrieves the start form variables for a process definition. The start form variables take form data specified on the start event into account.
        /// If form fields are defined, the variable types and default values of the form fields are taken into account.
        /// </summary>
        public abstract Task<Dictionary<string, VariableValue>> GetFormVariables(params string[] variableNames);
    }
}
