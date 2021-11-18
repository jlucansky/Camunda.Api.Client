using System;
using System.Collections.Generic;
using System.Text;

namespace Camunda.Api.Client.History
{
    public class HistoricUserOperationLogAnnotation
    {
         /// <summary>
         /// An arbitrary annotation set by a user for auditing reasons.
         /// </summary>
        public string Annotation { get; set; }
    }
}