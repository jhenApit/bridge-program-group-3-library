using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateHelperLibrary
{
    public class DateHelperClass
    {
        /// <summary>
        /// Gets the current date time.
        /// </summary>
        /// <returns>The current date and time.</returns>
        public DateTime GetCurrentDateTime()
        {
            return DateTime.Now;
        }

        /// <summary>
        /// Determines whether a given year is a leap year.
        /// </summary>
        /// <param name="year">The year to check.</param>
        /// <returns>
        ///   <c>true</c> if the specified year is a leap year; otherwise, <c>false</c>.
        /// </returns>
        public bool IsLeapYear(int year)
        {
            return DateTime.IsLeapYear(year);
        }

        /// <summary>
        /// Returns the day of the week for a given date.
        /// </summary>
        /// <param name="date">The date for which to determine the day of the week.</param>
        /// <returns>The day of the week as defined in the DayOfWeek enum.</returns>
        public DayOfWeek GetDayOfWeek(DateTime date)
        {
            return date.DayOfWeek;
        }

        /// <summary>
        /// Calculate the age based on a given birthdate
        /// </summary>
        /// <param name="birthDate">The date of birth.</param>
        /// <returns>An age in integer format</returns>
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

        /// <summary>
        /// Format the input Date and Time based on the format
        /// Date and Time that you provide
        /// </summary>
        /// 
        /// Sample:
        ///         Input Date and Time: YYYY-MM-DD HH:MM:SS
        ///         Input the format Date and Time: MM/dd/yyyy HH:mm:ss
        /// 
        /// <param name="dateTime">Input Date and Time</param>
        /// <param name="format">Input the new format of the Date and Time</param>
        /// <returns>New format of the Date and Time</returns>
        public static string FormatDateTime(DateTime dateTime, string format)
        {
            return dateTime.ToString(format);
        }

        /// <summary>
        /// Calculates the time difference between the start and end date and time.
        /// </summary>
        /// <param name="startDateTime">The start date and time.</param>
        /// <param name="endDateTime">The end date and time.</param>
        /// <returns>The time span representing the difference between the start and end date and time.</returns>
        public TimeSpan GetTimeDifference(DateTime startDateTime, DateTime endDateTime)
        {
            return endDateTime - startDateTime;
        }

        /// <summary>
        /// Adds any number of days to the given date.
        /// </summary>
        /// <param name="date">Date with year, month, and day.</param>
        /// <param name="days">Number of days to add in the given date.</param>
        /// <returns>Updated date</returns>
        public DateTime AddDays(DateTime date, int days)
        {
            return date.AddDays(days);
        }
    }
}
