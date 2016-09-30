using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Problem
{
    class SweettsDessert
    {
        static void Main(string[] args)
        {

            double cash = double.Parse(Console.ReadLine());
            int guests = int.Parse(Console.ReadLine());
            double priceBananas = double.Parse(Console.ReadLine());
            double priceEggs = double.Parse(Console.ReadLine());
            double priceBerries = double.Parse(Console.ReadLine());
            int portions = 0;
            double needMoney = 0;
            
            if (guests % 6 == 0)
            {
                portions = guests / 6;
            }
            if (guests % 6 > 0)
            {
                portions = (guests / 6) + 1;
            }
            needMoney = portions * (2 * priceBananas) + portions * (4 * priceEggs) + portions * (0.2 * priceBerries);

            if (cash >= needMoney)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {needMoney:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {needMoney - cash:f2}lv more.");
            }
        }
    }
}
