using System;
using System.Globalization;

namespace ConsoleApp.Extensions
{
    public static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan ts = DateTime.Now.Subtract(thisObj);
            if (ts.TotalSeconds < 60)
            {
                return ts.TotalSeconds.ToString("F1", CultureInfo.InvariantCulture) + " second(s)";
            }
            else if (ts.TotalMinutes < 60)
            {
                return ts.TotalMinutes.ToString("F1", CultureInfo.InvariantCulture) + " minute(s)";
            }
            else if (ts.TotalHours < 24)
            {
                return ts.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hour(s)";

            }
            else
            {
                return ts.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " day(s)"; ;
            }
            
        }
    }
}
