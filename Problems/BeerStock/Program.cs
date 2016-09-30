using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerStock
{
    class Program
    {
        static void Main(string[] args)
        {
            int reservedBeers = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            long amountBeer = 0;
            while (input != "Exam Over")
            {
                string[] data = input.Split(' ');
                long n = long.Parse(data[0]);
                var type = data[1];
                if (type == "beers")
                {
                    amountBeer += n;
                }
                if (type == "sixpacks")
                {
                    amountBeer += n * 6;
                }
                if (type == "cases")
                {
                    amountBeer += n * 24;
                }

                input = Console.ReadLine();
            }

            amountBeer = amountBeer - (amountBeer / 100);
            if (reservedBeers > amountBeer)
            {
                Console.WriteLine($"Not enough beer. Beer needed: {(reservedBeers - amountBeer) / 24} cases, {((reservedBeers - amountBeer) % 24) / 6} sixpacks and {((reservedBeers - amountBeer) % 24) % 6} beers.");
            }
            else
            {
                Console.WriteLine($"Cheers! Beer left: {(amountBeer - reservedBeers) / 24} cases, {((amountBeer - reservedBeers) % 24) / 6} sixpacks and {((amountBeer - reservedBeers) % 24) % 6} beers.");
            }
        }
    }
}
