using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"Before:\na = {b}\nb = {a}\nAfter:\na = {a}\nb = {b}");
        }
    }
}
