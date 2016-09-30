using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Buterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (var row = 0; row < ((2 * (n - 2)) + 1) / 2; row++)
            {
                if (row % 2 == 0)
                {

                    Console.Write(new string('*', n - 2));
                    Console.Write("\\");
                    Console.Write(" ");
                    Console.Write("/");
                    Console.WriteLine(new string('*', n - 2));
                }

                if (row % 2 == 1)
                {
                    Console.Write(new string('-', n - 2));
                    Console.Write("\\");
                    Console.Write(" ");
                    Console.Write("/");
                    Console.WriteLine(new string('-', n - 2));


                }

            }

            Console.Write(new string(' ', n - 1));
            Console.Write("@");
            Console.WriteLine(new string(' ', n - 1));

            for (var row = 0; row < ((2 * (n - 2)) + 1) / 2; row++)
            {
                if (row % 2 == 0)
                {

                    Console.Write(new string('*', n - 2));
                    Console.Write("/");
                    Console.Write(" ");
                    Console.Write("\\");
                    Console.WriteLine(new string('*', n - 2));
                }
                if (row == (((2 * (n - 2)) + 1) / 2) + 1)
                {
                    Console.WriteLine("@");
                }

                if (row % 2 == 1)
                {
                    Console.Write(new string('-', n - 2));
                    Console.Write("/");
                    Console.Write(" ");
                    Console.Write("\\");
                    Console.WriteLine(new string('-', n - 2));


                }
            }
        }
    }
}
