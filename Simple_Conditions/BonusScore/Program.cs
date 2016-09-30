using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            double bonusScore = 0.0;

            if (num <= 100)
            {
                bonusScore += 5;
            }
            else if (num <= 1000)
            {
                bonusScore = num * 0.2;
            }
            else
            {
                bonusScore = num * 0.1;
            }
            if (num % 2 == 0)
            {
                bonusScore += 1;
            }
            if (num % 10 == 5)
            {
                bonusScore += 2;
            }

            Console.WriteLine(bonusScore);
            Console.WriteLine(num + bonusScore);
        }
    }
}
