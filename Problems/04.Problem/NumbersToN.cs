using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Problem
{
    class NumbersToN
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int num = 1; num <= n; num++)
            {
                int sumOfDigits = 0;
                int digits = num;

                sumOfDigits += digits;
                digits = (digits / 10) % 10;

                Console.WriteLine("{0}", sumOfDigits);

            }
        }
    }
}
