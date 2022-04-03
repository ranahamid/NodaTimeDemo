// See https://aka.ms/new-console-template for more information

using System.Globalization;
using NodaTime;
using NodaTimeDemo;

Console.WriteLine("Hello, World!");

//http://www.codedigest.com/CodeDigest/207-Get-All-Language-Country-Code-List-for-all-Culture-in-C---ASP-Net.aspx
CultureInfo culture = new CultureInfo("en-US");
//https://nodatime.org/TimeZones
DateTimeZone timeZone = DateTimeZoneProviders.Tzdb["Asia/Dhaka"];
var instant = Instant.FromDateTimeUtc(DateTime.Now.ToUniversalTime());
ZonedDateTime nowZonedDateTime = new ZonedDateTime(instant, timeZone);
String nodaFormat = nowZonedDateTime.LocalDateTime.ToString(culture.DateTimeFormat.ShortDatePattern, culture);

//https://ml-software.ch/posts/using-nodatime-to-replace-c-datetime
ClockService service = new ClockService();
var now= service.Now;
var local = service.LocalNow;

var time = NodaTimeExtensions.ToDateTimeString(local);
var time2 = NodaTimeExtensions.ToShortDateString(local.Date);
Console.ReadKey();