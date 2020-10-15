using System;
using System.Collections.Generic;
using System.Text;

namespace Camunda.Api.Client.History
{
    public class HistoricTaskQuery: SortableQuery<HistoricTaskQuerySorting, HistoricTaskQuery>
    {
        /// <summary>
        /// Filter by task id.
        /// </summary>
        public string TaskId;

        /// <summary>
        /// Filter by parent task id.
        /// </summary>
        public string TaskParentTaskId;

        /// <summary>
        /// Filter by process instance id.
        /// </summary>
        public string ProcessInstanceId;

        /// <summary>
        /// Filter by process instance business key.
        /// </summary>
        public string ProcessInstanceBusinessKey;

        /// <summary>
        /// Filter by process instances with one of the give business keys. The keys need to be in a comma-separated list.
        /// </summary>
        public List<string> ProcessInstanceBusinessKeyIn;

        /// <summary>
        /// Filter by process instance business key that has the parameter value as a substring.
        /// </summary>
        public string ProcessInstanceBusinessKeyLike;

        /// <summary>
        /// Filter by the id of the execution that executed the task.
        /// </summary>
        public string ExecutionId;

        /// <summary>
        /// Filter by process definition id.
        /// </summary>
        public string ProcessDefinitionId;

        /// <summary>
        /// Restrict to tasks that belong to a process definition with the given key.
        /// </summary>
        public string ProcessDefinitionKey;

        /// <summary>
        /// Restrict to tasks that belong to a process definition with the given name.
        /// </summary>
        public string ProcessDefinitionName;

        /// <summary>
        /// Filter by case instance id.
        /// </summary>
        public string CaseInstanceId;

        /// <summary>
        /// Filter by the id of the case execution that executed the task.
        /// </summary>
        public string CaseExecutionId;

        /// <summary>
        /// Filter by case definition id.
        /// </summary>
        public string CaseDefinitionId;

        /// <summary>
        /// Restrict to tasks that belong to a case definition with the given key.
        /// </summary>
        public string CaseDefinitionKey;

        /// <summary>
        /// Restrict to tasks that belong to a case definition with the given name.
        /// </summary>
        public string CaseDefinitionName;

        /// <summary>
        /// Only include tasks which belong to one of the passed and comma-separated activity instance ids.
        /// </summary>
        public List<string> ActivityInstanceIdIn;

        /// <summary>
        /// Restrict to tasks that have the given name.
        /// </summary>
        public string TaskName;

        /// <summary>
        /// Restrict to tasks that have a name with the given parameter value as substring.
        /// </summary>
        public string TaskNameLike;

        /// <summary>
        /// Restrict to tasks that have the given description.
        /// </summary>
        public string TaskDescription;

        /// <summary>
        /// Restrict to tasks that have a description that has the parameter value as a substring.
        /// </summary>
        public string TaskDescriptionLike;

        /// <summary>
        /// Restrict to tasks that have the given key.
        /// </summary>
        public string TaskDefinitionKey;

        /// <summary>
        /// Restrict to tasks that have one of the passed and comma-separated task definition keys.
        /// </summary>
        public List<string> TaskDefinitionKeyIn;

        /// <summary>
        /// Restrict to tasks that have the given delete reason.
        /// </summary>
        public string TaskDeleteReason;

        /// <summary>
        /// Restrict to tasks that have a delete reason that has the parameter value as a substring.
        /// </summary>
        public string TaskDeleteReasonLike;

        /// <summary>
        /// Restrict to tasks that the given user is assigned to.
        /// </summary>
        public string TaskAssignee;

        /// <summary>
        /// Restrict to tasks that are assigned to users with the parameter value as a substring.
        /// </summary>
        public string TaskAssigneeLike;

        /// <summary>
        /// Restrict to tasks that the given user owns.
        /// </summary>
        public string TaskOwner;

        /// <summary>
        /// Restrict to tasks that are owned by users with the parameter value as a substring.
        /// </summary>
        public string TaskOwnerLike;

        /// <summary>
        /// Restrict to tasks that have the given priority.
        /// </summary>
        public long? TaskPriority;

        /// <summary>
        /// If set to true, restricts the query to all tasks that are assigned.
        /// </summary>
        public bool? Assigned;

        /// <summary>
        /// If set to true, restricts the query to all tasks that are unassigned.
        /// </summary>
        public bool? Unassigned;

        /// <summary>
        /// Only include finished tasks.Value may only be true, as false is the default behavior.
        /// </summary>
        public bool? Finished;

        /// <summary>
        /// Only include unfinished tasks.Value may only be true, as false is the default behavior.
        /// </summary>
        public bool? Unfinished;

        /// <summary>
        /// Only include tasks of finished processes.Value may only be true, as false is the default behavior.
        /// </summary>
        public bool? ProcessFinished;

        /// <summary>
        /// Only include tasks of unfinished processes.Value may only be true, as false is the default behavior.
        /// </summary>
        public bool? ProcessUnfinished;

        /// <summary>
        /// Restrict to tasks that are due on the given date.By default*, the date must have the format yyyy-MM-dd'T'HH:mm:ss.SSSZ, e.g., 2013-01-23T14:42:45.000+0200.
        /// </summary>
        public DateTime? TaskDueDate;

        /// <summary>
        /// Restrict to tasks that are due before the given date.By default*, the date must have the format yyyy-MM-dd'T'HH:mm:ss.SSSZ, e.g., 2013-01-23T14:42:45.000+0200.
        /// </summary>
        public DateTime? TaskDueDateBefore;

        /// <summary>
        /// Restrict to tasks that are due after the given date.By default*, the date must have the format yyyy-MM-dd'T'HH:mm:ss.SSSZ, e.g., 2013-01-23T14:42:45.000+0200.
        /// </summary>
        public DateTime? TaskDueDateAfter;

        /// <summary>
        /// Restrict to tasks that have a followUp date on the given date.By default*, the date must have the format yyyy-MM-dd'T'HH:mm:ss.SSSZ, e.g., 2013-01-23T14:42:45.000+0200.
        /// </summary>
        public DateTime? TaskFollowUpDate;

        /// <summary>
        /// Restrict to tasks that have a followUp date before the given date.By default*, the date must have the format yyyy-MM-dd'T'HH:mm:ss.SSSZ, e.g., 2013-01-23T14:42:45.000+0200.
        /// </summary>
        public DateTime? TaskFollowUpDateBefore;

        /// <summary>
        /// Restrict to tasks that have a followUp date after the given date.By default*, the date must have the format yyyy-MM-dd'T'HH:mm:ss.SSSZ, e.g., 2013-01-23T14:42:45.000+0200.
        /// </summary>
        public DateTime? TaskFollowUpDateAfter;

        /// <summary>
        /// Restrict to tasks that were started before the given date.By default*, the date must have the format yyyy-MM-dd'T'HH:mm:ss.SSSZ, e.g., 2013-01-23T14:42:45.000+0200.
        /// </summary>
        public DateTime? StartedBefore;

        /// <summary>
        /// Restrict to tasks that were started after the given date.By default*, the date must have the format yyyy-MM-dd'T'HH:mm:ss.SSSZ, e.g., 2013-01-23T14:42:45.000+0200.
        /// </summary>
        public DateTime? StartedAfter;

        /// <summary>
        /// Restrict to tasks that were finished before the given date.By default*, the date must have the format yyyy-MM-dd'T'HH:mm:ss.SSSZ, e.g., 2013-01-23T14:42:45.000+0200.
        /// </summary>
        public DateTime? FinishedBefore;

        /// <summary>
        /// Restrict to tasks that were finished after the given date.By default*, the date must have the format yyyy-MM-dd'T'HH:mm:ss.SSSZ, e.g., 2013-01-23T14:42:45.000+0200.
        /// </summary>
        public DateTime? FinishedAfter;

        /// <summary>
        /// Filter by a comma-separated list of tenant ids.A task instance must have one of the given tenant ids.
        /// </summary>
        public List<string> TenantIdIn;

        /// <summary>
        /// An array to only include tasks that have variables with certain values. 
        /// The array consists of objects with the three properties name, operator and value.
        /// Name(String) is the variable name, operator is the comparison operator to be used and value the variable value. 
        /// Value may be String, Number or Boolean.
        /// </summary>
        public List<VariableQueryParameter> TaskVariables = new List<VariableQueryParameter>();

        /// <summary>
        /// An array to only include tasks that belong to process instances that have variables with certain values. 
        /// The array consists of objects with the three properties name, operator and value.
        /// Name(String) is the variable name, operator is the comparison operator to be used and value the variable value. 
        /// Value may be String, Number or Boolean.
        /// </summary>
        public List<VariableQueryParameter> ProcessVariables = new List<VariableQueryParameter>();

        /// <summary>
        /// Restrict to tasks with a historic identity link to the given user.
        /// </summary>
        public string TaskInvolvedUser;

        /// <summary>
        /// Restrict to tasks with a historic identity link to the given group.
        /// </summary>
        public string TaskInvolvedGroup;

        /// <summary>
        /// Restrict to tasks with a historic identity link to the given candidate user.
        /// </summary>
        public string TaskHadCandidateUser;

        /// <summary>
        /// Restrict to tasks with a historic identity link to the given candidate group.
        /// </summary>
        public string TaskHadCandidateGroup;

        /// <summary>
        /// Only include tasks which have a candidate group.Value may only be true, as false is the default behavior.
        /// </summary>
        public bool? WithCandidateGroups;

        /// <summary>
        /// Only include tasks which have no candidate group.Value may only be true, as false is the default behavior.esults if there are no more results left.
        /// </summary>
        public bool? WithoutCandidateGroups;
    }

    public enum HistoricTaskQuerySorting
    {
        TaskId,
        ActivityInstanceId,
        ProcessDefinitionId,
        ProcessInstanceId,
        ExecutionId,
        Duration, 
        EndTime, 
        StartTime, 
        TaskName, 
        TaskDescription, 
        Assignee, 
        Owner, 
        DueDate, 
        FollowUpDate, 
        DeleteReason, 
        TaskDefinitionKey, 
        Priority, 
        CaseDefinitionId, 
        CaseInstanceId, 
        CaseExecutionId,
        TenantId
    }
}
