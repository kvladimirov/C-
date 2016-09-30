using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaidTowel
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char background = char.Parse(Console.ReadLine());
            char rhombus = char.Parse(Console.ReadLine());

            Console.WriteLine($"{new string(background, n)}{new string(rhombus, 1)}{ new string(background, 2 * n - 1)}{new string(rhombus, 1)}{new string(background, n)}");
            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine($"{new string(background, n - i - 1)}{new string(rhombus, 1)}{new string(background, 1 + 2 * i)}{new string(rhombus, 1)}{ new string(background, (2 * n - 1) - 2 * i - 2)}{new string(rhombus, 1)}{new string(background, 1 + 2 * i)}{new string(rhombus, 1)}{new string(background, n - i - 1)}");
            }
            Console.WriteLine($"{new string(rhombus, 1)}{ new string(background, 2 * n - 1)}{new string(rhombus, 1)}{ new string(background, 2 * n - 1)}{new string(rhombus, 1)}");
            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine($"{new string(background, i + 1)}{new string(rhombus, 1)}{new string(background, (2 * n - 3) - 2 * i)}{new string(rhombus, 1)}{ new string(background, 1 + 2 * i)}{new string(rhombus, 1)}{new string(background, (2 * n - 3) - 2 * i)}{new string(rhombus, 1)}{new string(background, i + 1)}");
            }
            Console.WriteLine($"{new string(background, n)}{new string(rhombus, 1)}{ new string(background, 2 * n - 1)}{new string(rhombus, 1)}{new string(background, n)}");
            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine($"{new string(background, n - i - 1)}{new string(rhombus, 1)}{new string(background, 1 + 2 * i)}{new string(rhombus, 1)}{ new string(background, (2 * n - 1) - 2 * i - 2)}{new string(rhombus, 1)}{new string(background, 1 + 2 * i)}{new string(rhombus, 1)}{new string(background, n - i - 1)}");
            }
            Console.WriteLine($"{new string(rhombus, 1)}{ new string(background, 2 * n - 1)}{new string(rhombus, 1)}{ new string(background, 2 * n - 1)}{new string(rhombus, 1)}");
            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine($"{new string(background, i + 1)}{new string(rhombus, 1)}{new string(background, (2 * n - 3) - 2 * i)}{new string(rhombus, 1)}{ new string(background, 1 + 2 * i)}{new string(rhombus, 1)}{new string(background, (2 * n - 3) - 2 * i)}{new string(rhombus, 1)}{new string(background, i + 1)}");
            }
            Console.WriteLine($"{new string(background, n)}{new string(rhombus, 1)}{ new string(background, 2 * n - 1)}{new string(rhombus, 1)}{new string(background, n)}");
        }
    }
}
