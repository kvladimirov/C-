using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            var max = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                var currentNum = int.Parse(Console.ReadLine());
                sum += currentNum;
                if (currentNum > max)
                {
                    max = currentNum;
                }
            }
            if (max == sum - max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + max);
            }
            else
            {
                Console.WriteLine("no diff = " + Math.Abs(max - (sum - max)));
            }     
        }
    }
}
