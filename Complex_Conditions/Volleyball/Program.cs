using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var year = Console.ReadLine();
            var p = int.Parse(Console.ReadLine());
            var h = int.Parse(Console.ReadLine());
            var m = 0.0;

            if (year == "normal")
            {
                m = (((48 - h) * 3.0 / 4) + h + (p * 2.0 / 3));
            }
            if (year == "leap")
            {
                m = (((48 - h) * 3.0 / 4) + h + (p * 2.0 / 3));
                m = m + (m * 0.15);
            }
            Console.WriteLine(Math.Truncate(m));

        }
    }
}
