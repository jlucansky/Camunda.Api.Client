using System;
using System.Collections.Generic;
using System.Text;

namespace Camunda.Api.Client
{
    public interface IQueryParameters
    {
        IDictionary<string, string> GetParameters();
    }
}
