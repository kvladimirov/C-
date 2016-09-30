using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            var prime = true;

            
            for (var i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0 || n < 2)
                {
                    prime = false;
                    break;
                }
            }
   
            if (prime == false || n < 2)
            {
                Console.WriteLine("Not prime");
            }

            else
            {
                Console.WriteLine("Prime");
            }
        }
    }
}
