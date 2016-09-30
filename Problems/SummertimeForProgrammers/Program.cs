using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummertimeForProgrammers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"{new string(' ', ((2 * n) - (n + 1)) / 2)}{new string('*', n + 1)}{new string(' ', ((2 * n) - (n + 1)) / 2)}");
            for (int i = 0; i < n / 2 + 1; i++)
            {
                Console.WriteLine($"{new string(' ', ((2 * n) - (n + 1)) / 2)}*{new string(' ', n - 1)}*{new string(' ', ((2 * n) - (n + 1)) / 2)}");
            }
            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.WriteLine($"{new string(' ', ((2 * n) - (n + 2 * i)) / 2 - 1)}*{new string(' ', n + 2 * i + 1)}*{new string(' ', ((2 * n) - (n + 2 * i)) / 2 - 1)}");
            }
            for (int i = 0; i < n; i++)
            { 
                Console.WriteLine($"*{new string('.', 2 * n - 2)}*");
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"*{new string('@', 2 * n - 2)}*");
            }
            Console.WriteLine($"{new string('*', 2 * n)}");
        }
    }
}
