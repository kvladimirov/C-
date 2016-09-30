using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CountWorkingDays
{
    class CountWorkingDays
    {
        static void Main(string[] args)
        {
            var startDate = DateTime.ParseExact(Console.ReadLine(), "d-M-yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(Console.ReadLine(), "d-M-yyyy", CultureInfo.InvariantCulture);
            DateTime[] holidays = new DateTime[]
             {new DateTime(2016, 1, 1),
             new DateTime(2016, 3, 3),
             new DateTime(2016, 5, 1),
             new DateTime(2016, 5, 6),
             new DateTime(2016, 5, 24),
             new DateTime(2016, 9, 6),
             new DateTime(2016, 9, 22),
             new DateTime(2016, 11, 1),
             new DateTime(2016, 12, 24),
             new DateTime(2016, 12, 25),
             new DateTime(2016, 12, 26),
             };
            int workingDaysCount = 0;
            for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
            {
                
                DateTime currDate = new DateTime (2016, i.Month, i.Day);
                
                if (!holidays.Contains(currDate) && i.DayOfWeek != DayOfWeek.Sunday && i.DayOfWeek != DayOfWeek.Saturday) 
                {
                    workingDaysCount++;
                }
                       
            }

            Console.WriteLine(workingDaysCount);
        }
    }
}

