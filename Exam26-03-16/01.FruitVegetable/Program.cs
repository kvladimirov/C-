using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FruitVegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceVegetables = double.Parse(Console.ReadLine());
            double priceFruits = double.Parse(Console.ReadLine());
            var vegetables = int.Parse(Console.ReadLine());
            var fruits = int.Parse(Console.ReadLine());

            var sumFruitsVegetables = ((vegetables * priceVegetables) + (fruits * priceFruits)) / 1.94;

            Console.WriteLine(sumFruitsVegetables);
            

        }
    }
}
