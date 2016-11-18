using System.Collections.Generic;
using System.Linq;

namespace Camunda.Api.Client
{
    internal static class StringExtensions
    {
        public static string Join(this IEnumerable<string> str)
        {
            if (str == null || str.Count() == 0)
                return null;
            else
                return string.Join(",", str);
        }

    }
}
