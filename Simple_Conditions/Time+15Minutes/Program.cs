using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hh1 = int.Parse(Console.ReadLine());
            var mm1 = int.Parse(Console.ReadLine());
            var mm2 = mm1 + 15;
            var hh2 = 0;

            if (mm2 <= 59)
            {
                Console.WriteLine("{0}:{1:00}", hh1, mm2);
            }
            if (mm2 > 59)
            {
                if (hh1 < 23)
                {
                    Console.WriteLine("{0}:{1:00}", hh1 += 1, mm2 -= 60);
                }
                else
                {
                    Console.WriteLine("{0}:{1:00}", 0, mm2 -=60);
                }
            }
            
       }
    }
}
