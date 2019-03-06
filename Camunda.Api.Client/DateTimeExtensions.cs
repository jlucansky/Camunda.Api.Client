using System;
using System.Globalization;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Camunda.Api.Client.Tests")]
namespace Camunda.Api.Client
{
    internal static class DateTimeExtensions
    {
        const string _dateTimeFormat = "yyyy-MM-ddTHH\\:mm\\:ss.fffzzz";

        public static string ToJavaISO8601(this DateTime dateTime)
        {
            return ReplaceLastOccurrence(dateTime.ToString(_dateTimeFormat, CultureInfo.InvariantCulture), ":", "");
        }

        private static string ReplaceLastOccurrence(string Source, string Find, string Replace)
        {
            int place = Source.LastIndexOf(Find);

            if (place == -1)
                return Source;

            return Source.Remove(place, Find.Length).Insert(place, Replace);

        }
    }
}
