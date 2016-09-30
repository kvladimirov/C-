using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Problem
{
    class Strawberry
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine($"{new string('-', 2 * i)}\\{new string('-', n - 2 * i)}|{new string('-', n - 2 * i)}/{new string('-', 2 * i)}");
            }
            
            for (int i = 0; i < n / 2 + 1; i++)
            {
                Console.WriteLine($"{new string('-', n - 2 * i)}#{new string('.', 1 + 4 * i)}#{new string('-', n - 2 * i)}");
            }
            
            for (int i = 0; i < n + 1; i++)
            {
                Console.WriteLine($"{new string('-', i)}#{new string('.', (2 * n + 1) - 2 * i)}#{new string('-', i)}");
            }
        }
    }
}
