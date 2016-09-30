using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            long[] primes = new long[n + 1];

            for (int i = 0; i <= n; i++)
            {
                if(PrimeChecker(i))
                {
                    primes[i] = i;
                }
            }

            foreach (int i in primes)
            {
                if (primes[i] > 0)
                {
                    Console.Write(primes[i] + " ");
                }
            }
            

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
