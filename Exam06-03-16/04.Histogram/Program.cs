using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var num1 = 0;
            var num2 = 0;
            var num3 = 0;
            var num4 = 0;
            var num5 = 0;

            for (var i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                

                if (num < 200)
                {
                    num1 += 1;     
                }

                if (num >= 200 && num <= 399)
                {
                    num2 += 1;
                }

                if (num >= 400 && num <= 599)
                {
                    num3 += 1;
                }

                if (num >= 600 && num <= 799)
                {
                    num4 += 1;
                }

                if (num >= 800)
                {
                    num5 += 1;
                }
            }
            var p1 = num1 * (100.00 / n);
            var p2 = num2 * (100.00 / n);
            var p3 = num3 * (100.00 / n);
            var p4 = num4 * (100.00 / n);
            var p5 = num5 * (100.00 / n);
            Console.WriteLine("{0:f2}%", p1);
            Console.WriteLine("{0:f2}%", p2);
            Console.WriteLine("{0:f2}%", p3);
            Console.WriteLine("{0:f2}%", p4);
            Console.WriteLine("{0:f2}%", p5);
        }
    }
}
