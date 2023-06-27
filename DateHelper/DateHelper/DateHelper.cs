using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DateHelperLibrary
{
    public class DateHelper
    {
        public DateTime GetCurrentDateTime()
        {
            return DateTime.Now;
        }

        public DayOfWeek GetDayOfWeek(DateTime date)
        {
            return date.DayOfWeek;
        }

        public string FormatDateTime(DateTime dateTime, string format)
        {
            return dateTime.ToString(format);
        }

         public TimeSpan GetTimeDifference(DateTime startDateTime, DateTime endDateTime)
        {
            return endDateTime - startDateTime;
        }
    }
}