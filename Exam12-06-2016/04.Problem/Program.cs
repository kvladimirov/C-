using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal pricePerCapsule = 0;
            var date = new DateTime();
            decimal capsulesCount = 0;
            int daysInMonth = 0;
            decimal totalPriceForTheCoffee = 0;
            for (int i = 0; i < n; i++)
            {
                pricePerCapsule = decimal.Parse(Console.ReadLine());
                date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                capsulesCount = decimal.Parse(Console.ReadLine());
                daysInMonth = GetDates(date.Year, date.Month);
                decimal priceForTheCoffee = ((daysInMonth * capsulesCount) * pricePerCapsule);
                totalPriceForTheCoffee += priceForTheCoffee;
                Console.WriteLine($"The price for the coffee is: ${priceForTheCoffee:f2}");
            }

            Console.WriteLine($"Total: ${totalPriceForTheCoffee:f2}");
        }
        public static int GetDates(int year, int month)
        {
            int dates = 0;
            for (var date = new DateTime(year, month, 1); date.Month == month; date = date.AddDays(1))
            {
                dates++;
            }

            return dates;
        }
    }
}
