using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Max(GetMax(num1, num2), num3));
        }
        static int GetMax(int num1, int num2)
        {
            int number = Math.Max(num1, num2);
            return number;
        }
    }
}
