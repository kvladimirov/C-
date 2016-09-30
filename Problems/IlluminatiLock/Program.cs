using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlluminatiLock
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"{new string('.', n)}{new string('#', n)}{new string('.', n)}");
            for (int i = 0; i < n / 2; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine($"{new string('.', n - 2)}###{new string('.', n - 2)}###{new string('.', n - 2)}");
                }

                else
                {
                    Console.WriteLine($"{new string('.', n - 2 - 2*i)}##{new string('.', 2*i)}#{new string('.', n - 2)}#{new string('.', 2*i)}##{new string('.', n - 2 - 2*i)}");
               }
            }
            for (int i = 0; i < n / 2; i++)
            {
                if (i == n / 2 - 1)
                {
                    Console.WriteLine($"{new string('.', n - 2)}###{new string('.', n - 2)}###{new string('.', n - 2)}");
                }
                else
                {
                    Console.WriteLine($"{new string('.', 2 * i + 1)}##{new string('.', n - 3 - 2 * i)}#{new string('.', n - 2)}#{new string('.', n - 3 - 2 * i)}##{new string('.', 2 * i + 1)}");
                }
            }
            Console.WriteLine($"{new string('.', n)}{new string('#', n)}{new string('.', n)}");
        }
    }
}
