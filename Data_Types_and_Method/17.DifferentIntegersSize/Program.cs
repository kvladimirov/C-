using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Numerics;
namespace _17.DifferentIntegersSize
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());

            if (n < long.MinValue || n > long.MaxValue)
            {
                Console.WriteLine($"{n} can't fit in any type");
            }

            else
            {
                Console.WriteLine($"{n} can fit in:");
            }

            if (n <= sbyte.MaxValue && n >= sbyte.MinValue)
            {
                Console.WriteLine("* sbyte");
            }

            if (n <= byte.MaxValue && n >= byte.MinValue)
            {
                Console.WriteLine("* byte");
            }
            
            if (n <= short.MaxValue && n >= short.MinValue)
            {
                Console.WriteLine("* short");
            }

            if (n <= ushort.MaxValue && n >= ushort.MinValue)
            {
                Console.WriteLine("* ushort");
            }

            if (n <= int.MaxValue && n >= int.MinValue)
            {
                Console.WriteLine("* int");
            }

            if (n <= uint.MaxValue && n >= uint.MinValue)
            {
                Console.WriteLine("* uint");
            }

            if (n <= long.MaxValue && n >= long.MinValue)
            {
                Console.WriteLine("* long");
            }
        }
    }
}
