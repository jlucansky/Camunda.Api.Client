using System;
using System.Collections.Generic;
using System.Text;

namespace Camunda.Api.Client.CaseExecution
{
    public class CaseExecutionInfo
    {
        //id String  The id of the case execution.
        //caseInstanceId String  The id of the case instance this case execution belongs to.
        //parentId String  The id of the parent of this case execution belongs to.
        //caseDefinitionId String  The id of the case definition this case execution belongs to.
        //activityId String  The id of the activity this case execution belongs to.
        //activityName String  The name of the activity this case execution belongs to.
        //activityType String  The type of the activity this case execution belongs to.
        //activityDescription String  The description of the activity this case execution belongs to.
        //required Boolean     A flag indicating whether the case execution is required or not.
        //repeatable Boolean     A flag indicating whether the case execution is repeatable or not.
        //repetition Boolean     A flag indicating whether the case execution is a repetition or not.
        //active Boolean     A flag indicating whether the case execution is active or not.
        //enabled Boolean     A flag indicating whether the case execution is enabled or not.
        //disabled Boolean     A flag indicating whether the case execution is disabled or not.
        //tenantId String  The tenant id of the case execution.
    }
}
