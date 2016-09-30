using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DelenieBezOst
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());


            var num1 = 0;
            var num2 = 0;
            var num3 = 0;

            for (var i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());


                if (num % 2 == 0)
                {
                    num1 += 1;
                }

                if (num % 3 == 0)
                {
                    num2 += 1;
                }

                if (num % 4 == 0)
                {
                    num3 += 1;
                }

            }
            var p1 = num1 * (100.00 / n);
            var p2 = num2 * (100.00 / n);
            var p3 = num3 * (100.00 / n);
            
            Console.WriteLine("{0:f2}%", p1);
            Console.WriteLine("{0:f2}%", p2);
            Console.WriteLine("{0:f2}%", p3);
        }
    }
}
