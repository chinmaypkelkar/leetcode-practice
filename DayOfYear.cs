using System.Collections.Generic;

namespace LeetcodePractice
{
    public class DayOfYear
    {
        private readonly int[] _noLeapYear = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        private readonly int[] _leapYear = {31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        public int GetDayOfYear(string date)
        {
            var split = date.Split("-");
            var year = int.Parse(split[0]);
            var month = int.Parse(split[1]);
            var day = int.Parse(split[2]);

            var daysOfMonthCount = 0;
            var i = 0;
            month -= 1;
            if (year % 4 == 0) // leap year
            {
                while (i < month)
                {
                    daysOfMonthCount += _leapYear[i];
                    i++;
                }
            }
            else
            {
                while (i < month)
                {
                    daysOfMonthCount += _noLeapYear[i];
                    i++;
                }
            }

            return daysOfMonthCount + day;
        }
    }
}