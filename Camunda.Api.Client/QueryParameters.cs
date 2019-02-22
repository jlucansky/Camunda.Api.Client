using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace Camunda.Api.Client
{
    public abstract class QueryParameters
    {
        public static implicit operator QueryDictionary(QueryParameters query)
        {
            QueryDictionary result = new QueryDictionary();
            var json = JsonConvert.DeserializeObject<Dictionary<string, JToken>>(JsonConvert.SerializeObject(query, CamundaClient.JsonSerializerSettings), CamundaClient.JsonSerializerSettings);

            foreach (var item in json)
            {
                string value;

                if (item.Value is JArray) // separate array items by comma
                    value = string.Join(",", item.Value.ToObject<string[]>());
                else if (item.Value.Type == JTokenType.Boolean) // True/False convert to lowercase
                    value = item.Value.ToObject<string>().ToLower();
                else if (item.Value.Type == JTokenType.Date)
                    value = item.Value.Value<DateTime>().ToJavaISO8601();
                else
                    value = item.Value.ToObject<string>();

                if (!string.IsNullOrEmpty(value))
                    result.Add(item.Key, value);
            }

            return result;
        }
        
    }

    public class QueryDictionary : Dictionary<string, string>
    {

    }
}
