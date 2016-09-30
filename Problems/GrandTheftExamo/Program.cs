using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandTheftExamo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int thievesSlapped = 0;
            ulong thievesEscaped = 0;
            ulong beers = 0;
            for (int i = 0; i < n; i++)
            {
                ulong t = ulong.Parse(Console.ReadLine());
                ulong b = ulong.Parse(Console.ReadLine());
                if (t < 5)
                {
                    thievesSlapped += (int)t;
                }
                else
                {
                    thievesSlapped += 5;
                }
                if (t > 5)
                {
                    thievesEscaped += t - 5;
                }
                beers += b;
            }
            Console.WriteLine($"{thievesSlapped} thieves slapped.");
            Console.WriteLine($"{thievesEscaped} thieves escaped.");
            Console.WriteLine($"{beers / 6} packs, {beers % 6} bottles.");
        }
    }
}
