using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(PrimeChecker(number));
           
        }
        static bool PrimeChecker(long num)
        {
            bool prime = true;

            if (num == 0 || num == 1)
            {
                prime = false;
            }

            for (var i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0 || num < 2)
                {
                    prime = false;
                    break;
                }
                else
                {
                    prime = true;
                }
            }
            return prime;
        }
    }
}
