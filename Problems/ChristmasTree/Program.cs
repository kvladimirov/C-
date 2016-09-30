using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n / 2 + 1; i++)
            {
                Console.WriteLine($"{new string('\'', n - i)}{new string('^', 1 + 2 * i)}{new string('\'', n - i)}");
            }
            for (int i = 1; i <= n / 2 + 1; i++)
            {
                Console.WriteLine($"{new string('\'', n - i)}{new string('^', 1 + 2 * i)}{new string('\'', n - i)}");
            }
            for (int i = 0; i < n / 2 + 1; i++)
            {
                Console.WriteLine($"{new string('\'', n - 1)}| |{new string('\'', n - 1)}");
            }
            Console.WriteLine($"{new string('-', 2 * n + 1)}");
        }
    }
}
