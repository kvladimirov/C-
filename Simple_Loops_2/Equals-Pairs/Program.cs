using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Pairs
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double previousSum = 0;
            double currentSum = 0;
            double diff = 0;
            double maxDiff = 0;

            for (int i = 0; i < n; i++)
            {
                double firstNumber = double.Parse(Console.ReadLine());
                double secondNumber = double.Parse(Console.ReadLine());

                if (i == 0)
                {
                    previousSum = firstNumber + secondNumber;
                }
                else
                {
                    currentSum = firstNumber + secondNumber;
                    diff = Math.Abs(currentSum - previousSum);
                    if (diff > maxDiff)
                    {
                        maxDiff = diff;
                    }
                    previousSum = currentSum;
                }
            }

            if (maxDiff == 0)
            {
                Console.WriteLine("Yes, value ={0}", previousSum);
            }
            else
            {
                Console.WriteLine("No, maxdiff ={0}", maxDiff);
            }
        }
    }
}
