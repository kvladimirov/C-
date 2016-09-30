using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CakeTicoon
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            uint f = uint.Parse(Console.ReadLine());
            uint t = uint.Parse(Console.ReadLine());
            uint p = uint.Parse(Console.ReadLine());

            ulong priceTruffles = (ulong)t * p;
            double cakes = Math.Floor(f / c);
            
            if (cakes > n)
            {
                
                double priceCake = ((double)priceTruffles / n) * 1.25;
                Console.WriteLine("All products available, price of a cake: {0:f2}", priceCake);
            }

            else
            {
                double kilogramneeded = (n * c) - f;
                Console.WriteLine("Can make only {0} cakes, need {1:f2} kg more flour", cakes, kilogramneeded);
            }
        }
    }
}
