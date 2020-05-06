namespace Camunda.Api.Client.CaseInstance
{
    public interface ICaseInstanceService
    {
        QueryResource<CaseInstanceQuery, CaseInstanceInfo> Query(CaseInstanceQuery query = null);
        CaseInstanceResource this[string caseInstanceId] { get; }
    }
}