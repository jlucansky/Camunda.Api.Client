using System;
using System.Globalization;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Camunda.Api.Client.Tests")]
namespace Camunda.Api.Client
{
    internal static class DateTimeExtensions
    {
        const string _dateTimeFormat = "yyyy-MM-ddTHH':'mm':'ss.fff";

        public static string ToJavaISO8601(this DateTime dateTime)
        {
            if (dateTime.Kind == DateTimeKind.Unspecified) // treat unspecified time as local time
                dateTime = new DateTime(dateTime.Ticks, DateTimeKind.Local);
            return dateTime.ToString(_dateTimeFormat, CultureInfo.InvariantCulture)
                + dateTime.ToString("%K").Replace(":", "").Replace("Z", "+0000");
        }
    }
}
