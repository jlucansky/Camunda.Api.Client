using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Refit;
using System.Collections.Generic;

namespace Camunda.Api.Client
{
    internal static class QueryExtensions
    {
        public static IDictionary<string, string> CreateQueryParameters(this IQueryParameters query)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            var json = JsonConvert.DeserializeObject<Dictionary<string, JToken>>(JsonConvert.SerializeObject(query, CamundaClient.JsonSerializerSettings), CamundaClient.JsonSerializerSettings);

            foreach (var item in json)
            {
                if (item.Value is JArray) // separate array items by comma
                    result.Add(item.Key, string.Join(",", item.Value.ToObject<string[]>()));
                else if (item.Value.Type == JTokenType.Boolean) // True/False convert to lowercase
                    result.Add(item.Key, item.Value.ToObject<string>().ToLower());
                else
                    result.Add(item.Key, item.Value.ToObject<string>());
            }

            return result;
        }
    }
}
