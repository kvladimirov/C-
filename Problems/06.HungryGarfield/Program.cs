using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.HungryGarfield
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            decimal rate = decimal.Parse(Console.ReadLine());
            decimal pizzaPrice = decimal.Parse(Console.ReadLine());
            decimal lasagnaPrice = decimal.Parse(Console.ReadLine());
            decimal sandwichPrice = decimal.Parse(Console.ReadLine());
            var pizzaQuantity = uint.Parse(Console.ReadLine());
            var lasagnaQuantity = uint.Parse(Console.ReadLine());
            var sandwichQuantity = uint.Parse(Console.ReadLine());

            decimal sum = pizzaPrice / rate * pizzaQuantity + lasagnaPrice / rate * lasagnaQuantity + sandwichPrice / rate * sandwichQuantity;
            if (sum < money)
            {
                decimal div = money - sum;
                Console.WriteLine($"Garfield is well fed, John is awesome. Money left: ${div:0.00}.");
            }
            else
            {
                decimal div = sum - money;
                Console.WriteLine($"Garfield is hungry. John is a badass. Money needed: ${div:0.00}.");
            }
        }    
    }
}
