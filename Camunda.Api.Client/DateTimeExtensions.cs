using System;
using System.Globalization;

namespace Camunda.Api.Client
{
    internal static class DateTimeExtensions
    {
        const string _dateTimeFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFF";

        public static string ToJavaISO8601(this DateTime dateTime)
        {
            return dateTime.ToString(_dateTimeFormat, CultureInfo.InvariantCulture)
                + dateTime.ToString("%K").Replace(":", "").Replace("Z", "UTC");
        }
    }
}
