using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Camunda.Api.Client
{
    public interface IVariableResource
    {
        Task<Dictionary<string, VariableValue>> GetAll();
        Task<VariableValue> Get(string variableName);
        Task<HttpContent> GetBinary(string variableName);
        Task Set(string variableName, VariableValue variable);
        Task SetBinary(string variableName, BinaryDataContent data, BinaryVariableType valueType);
        Task Delete(string variableName);
        Task Modify(PatchVariables patch);
    }
}
