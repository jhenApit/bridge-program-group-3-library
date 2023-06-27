using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DateHelperLibrary
{
    public class DateHelper
    {
        public DateTime GetCurrentDateTime()
        {
            return DateTime.Now;
        }
        /// <summary>
        /// this method returns true if year is leap year :))
        /// </summary>
        /// <param name="year"> year for example 2020 </param>
        /// <returns>bool,either true or false </returns>
        public bool IsLeapYear (int year)
        {
            return DateTime.IsLeapYear(year);
        }
        public DayOfWeek GetDayOfWeek(DateTime date)
        {
            return date.DayOfWeek;
        }

        public int CalculateAge(DateTime birthDate)
        {
            int age = DateTime.Now.Year - birthDate.Year;

            if (DateTime.Now.Month < birthDate.Month ||
                (DateTime.Now.Month == birthDate.Month && DateTime.Now.Day < birthDate.Day))
            {
                age--;
            }

            return age;
        }

        public string FormatDateTime(DateTime dateTime, string format)
        {
            return dateTime.ToString(format); 
        }

         public TimeSpan GetTimeDifference(DateTime startDateTime, DateTime endDateTime)
        {
            return endDateTime - startDateTime;
        }

        public DateTime AddDays(DateTime date, int days)
        {
            return date.AddDays(days);
        }
    }
}