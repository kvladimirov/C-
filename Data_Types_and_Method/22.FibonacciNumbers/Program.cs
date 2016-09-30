using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("Invalid input!");
                return;
            }
            if (n == 0)
            {
                Console.WriteLine(1);
                return;
            }
            if (n == 1)
            {
                Console.WriteLine(1);
                return;
            }
            Console.WriteLine($"{FibonacciNumbers(n)}");
        }
        private static int FibonacciNumbers(int n)
        {
            int n1 = 0;
            int n2 = 1;
            int n3 = 0;
            for (int i = 0; i < n; i++)
            {
                n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
            }
            return n3;
        }
    }
}
