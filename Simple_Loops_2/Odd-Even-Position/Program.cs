using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var oddSum = 0.0;
            var oddMin = 1000000000.0;
            var oddMax = -1000000000.0;
            var evenSum = 0.0;
            var evenMin = 1000000000.0;
            var evenMax = -1000000000.0;

            for (double i = 0; i < n; i++)
            {
                var element = double.Parse(Console.ReadLine());
                
                if (i % 2 == 0)
                {
                    oddSum += element;
                    if (element < oddMin)
                    {
                        oddMin = element;
                    }
                    if (element > oddMax)
                    {
                        oddMax = element;
                    }
                }
                if (i % 2 == 1)
                {
                    evenSum += element;
                    if (element < evenMin)
                    {
                        evenMin = element;
                    }
                    if (element > evenMax)
                    {
                        evenMax = element;
                    }
                }
            }
            if (n == 0)
            {
                Console.WriteLine("OddSum=0");
                Console.WriteLine("OddMin=No");
                Console.WriteLine("OddMax=No");
                Console.WriteLine("EvenSum=0");
                Console.WriteLine("EvenMin=No");
                Console.WriteLine("EvenMax=No");
            }
            if (n == 1)
            {
                Console.WriteLine("OddSum={0}", oddSum);
                Console.WriteLine("OddMin={0}", oddMin);
                Console.WriteLine("OddMax={0}", oddMax);
                Console.WriteLine("EvenSum=0");
                Console.WriteLine("EvenMin=No");
                Console.WriteLine("EvenMax=No");
            }
            if (n > 1)
            {
                Console.WriteLine("OddSum={0}", oddSum);
                Console.WriteLine("OddMin={0}", oddMin);
                Console.WriteLine("OddMax={0}", oddMax);
                Console.WriteLine("EvenSum={0}", evenSum);
                Console.WriteLine("EvenMin={0}", evenMin);
                Console.WriteLine("EvenMax={0}", evenMax);
            }
        }
    }
}
