﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunlight
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"{new string('.', (3 * n) / 2)}*{new string('.', (3 * n) / 2)}");
            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine($"{new string('.', i + 1)}*{new string('.', (3 * n) / 2 - i - 2)}*{new string('.', (3 * n) / 2 - i - 2)}*{new string('.', i + 1)}");
            }
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine($"{new string('.', n)}{new string('*', n)}{new string('.', n)}");
            }
                      
            Console.WriteLine($"{new string('*', 3 * n)}");
            
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine($"{new string('.', n)}{new string('*', n)}{new string('.', n)}");
            }
            for (int i = 0; i < n - 1; i++)
            {

                Console.WriteLine($"{new string('.', n - i - 1)}*{new string('.', n / 2 + i)}*{new string('.', n / 2 + i)}*{new string('.', n - i - 1)}");

            }
            Console.WriteLine($"{new string('.', (3 * n) / 2)}*{new string('.', (3 * n) / 2)}");
        }
    }
}
