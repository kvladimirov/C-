using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AceOfDiamonds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"{new string('*', n)}");
            for (int i = 0; i < n / 2; i++)
            { 
               
                    Console.WriteLine($"*{new string('-', (n - 2 - (2 * i)) / 2)}{new string('@', 2 * i + 1)}{new string('-', (n - 2 - (2 * i)) / 2)}*");

            }
            for (int i = 1; i < n / 2; i++)
            {

                Console.WriteLine($"*{new string('-', i)}{new string('@', n - 2 - 2 * i)}{new string('-', i)}*");

            }
            Console.WriteLine($"{new string('*', n)}");
        }
    }
}
