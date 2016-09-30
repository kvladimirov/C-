using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertorHArd
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            var first = Console.ReadLine().ToLower();
            var second = Console.ReadLine().ToLower();

            if (first == "usd")
                num *= 1.79549;
            else if (first == "gbp")
                num *= 2.53405;
            else if (first == "eur")
                num *= 1.95583;

            if (second == "usd")
                num /= 1.79549;
            else if (second == "gbp")
                num /= 2.53405;
            else if (second == "eur")
                num /= 1.95583;
            Console.WriteLine(Math.Round(num, 2));
        }
    }
}
