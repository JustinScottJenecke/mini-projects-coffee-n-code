using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerekBanasEasy
{
    public class DateTimePractice
    {
        // Basics of DateTime object
        public void createDate() { 
            DateTime testDate = DateTime.Now;
            Console.WriteLine($"Day of the week: {testDate.DayOfWeek}");
            // testDate.AddMonths(1);
            Console.WriteLine($"Next month of created date {testDate.Date} is: {testDate.AddMonths(1).Date}");
        }

        // Basics of Timespan - used to define a time
        public void setLunchTime() {
            TimeSpan lunchTime = new TimeSpan(12, 30, 0);
            lunchTime = lunchTime.Add(new TimeSpan(0, 30, 0)); // set lunch time to 13:00 
            
            Console.WriteLine(lunchTime.ToString());
        }

    }


}
