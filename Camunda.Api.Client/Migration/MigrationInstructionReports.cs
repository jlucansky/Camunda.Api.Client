using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Camunda.Api.Client.Migration
{
    public class MigrationInstructionReports
    {
        /// <summary>
        /// The list of instruction validation reports. If no validation errors are detected it is an empty list.
        /// </summary>
        [JsonProperty("instructionReports")]
        public List<MigrationInstructionReport> InstructionReports;
    }
}
