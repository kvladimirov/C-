using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var sec1 = int.Parse(Console.ReadLine());
            var sec2 = int.Parse(Console.ReadLine());
            var sec3 = int.Parse(Console.ReadLine());
            var secs = sec1 + sec2 + sec3;
            var mins = 0;

            if (secs > 59)
            {
                mins++;
                secs -= 60;
            }
            if (secs > 59)
            {
                mins++;
                secs -= 60;
            }
            
            Console.WriteLine("{0}:{1:00}", mins, secs);
            
        }
    }
}