using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Somewhere
{
    class Program
    {
        static void Main(string[] args)
        {
            double b = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();

            if (b <= 100)
            {
                if (season == "summer")
                {
                    double price = b * 0.30;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Camp - {0:f2}", price);
                }

                if (season == "winter")
                {
                    double price = b * 0.70;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Hotel - {0:f2}", price);
                }
            }

            if (b > 100 && b <= 1000)
            {
                if (season == "summer")
                {
                    double price = b * 0.40;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Camp - {0:f2}", price);
                }

                if (season == "winter")
                {
                    double price = b * 0.80;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Hotel - {0:f2}", price);
                }
            }

            if (b > 1000)
            {
                double price = b * 0.90;
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine("Hotel - {0:f2}", price);

            }
        }
    }
}
