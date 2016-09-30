using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SoftUniWaterSupplies
{
    class SoftUniWaterSupplies
    {
        static void Main(string[] args)
        {
            
            double liters = double.Parse(Console.ReadLine());
            double[] bottles = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double capacityBottle = double.Parse(Console.ReadLine());
            List<int> indexes = new List<int>();
            double needLiters = 0;
            if (liters % 2 == 0)
            {
                for (int i = 0; i < bottles.Length; i++)
                {
                    liters -= (capacityBottle - bottles[i]);
                    if (liters < 0)
                    {
                        indexes.Add(i);
                        needLiters += liters;
                        liters = 0;                       
                    }            
                }
                if (liters >= 0 && needLiters == 0)
                {
                    Console.WriteLine($"Enough water!\nWater left: {liters}l.");
                }
                if (needLiters < 0)
                {
                    Console.WriteLine($"We need more water!\nBottles left: {indexes.Count}");
                    Console.WriteLine($"With indexes: {string.Join(", ", indexes)}");
                    Console.WriteLine($"We need {Math.Abs(needLiters)} more liters!");
                }
                return;
            }
            if (liters % 2 == 1)
            {
                for (int i = bottles.Length - 1; i >= 0; i--)
                {
                    liters -= (capacityBottle - bottles[i]);
                    if (liters < 0)
                    {
                        indexes.Add(i);
                        needLiters += liters;
                        liters = 0;
                    }
                }
                if (liters >= 0 && needLiters == 0)
                {
                    Console.WriteLine($"Enough water!\nWater left: {liters}l.");
                }
                if (needLiters < 0)
                {
                    Console.WriteLine($"We need more water!\nBottles left: {indexes.Count}");
                    Console.WriteLine($"With indexes: {string.Join(", ", indexes)}");
                    Console.WriteLine($"We need {Math.Abs(needLiters)} more liters!");
                }
                return;
            }           
        }
    }
}
