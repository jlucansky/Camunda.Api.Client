using System;
using System.Globalization;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Camunda.Api.Client.Tests,PublicKey=" +
"00240000048000009400000006020000002400005253413100040000010001004196a3758b909b" +
"46774069391580d90f2078e831d76f42a00c3d584321fd9b394b12d3a46eab643bc339f526d1d9" +
"5f7450cfd7a0a0316ce2eea145b9d9013f6b677aac1333d94007c79c33e2804af6a749c732ac45" +
"90f17f078d33445a25c45598f744f0774d2c3d82e2a8b0309203be7e3d0b719f7825d4ded4577b" +
"435db7ae")]
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
