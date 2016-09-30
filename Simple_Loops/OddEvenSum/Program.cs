using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var evenSum = 0;
            var oddSum = 0;

            for (int i = 0; i < n; i++)
            {
                var element = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    oddSum += element;
                }
                else
                {
                    evenSum += element;
                }
            }
            if  (evenSum == oddSum)
            {
                Console.WriteLine("Yes sum " + evenSum);
            }
            else
            {
                Console.WriteLine("No diff " + Math.Abs(evenSum - oddSum));
            }
        }
    }
}
