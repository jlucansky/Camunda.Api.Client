using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Camunda.Api.Client.CaseExecution
{
    public class LocalVariableResource : IVariableResource
    {
        public Task Delete(string variableName)
        {
            throw new NotImplementedException();
        }

        public Task<VariableValue> Get(string variableName)
        {
            throw new NotImplementedException();
        }

        public Task<Dictionary<string, VariableValue>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<HttpContent> GetBinary(string variableName)
        {
            throw new NotImplementedException();
        }

        public Task Modify(PatchVariables patch)
        {
            throw new NotImplementedException();
        }

        public Task Set(string variableName, VariableValue variable)
        {
            throw new NotImplementedException();
        }

        public Task SetBinary(string variableName, BinaryDataContent data, BinaryVariableType valueType)
        {
            throw new NotImplementedException();
        }
    }
}