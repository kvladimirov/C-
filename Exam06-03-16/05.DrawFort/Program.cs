using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.DrawFort
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var colSize = n / 2;
            var midSize = (n * 2) - (colSize * 2 + 4);

            Console.WriteLine("/{0}\\{1}/{0}\\", new string('^', colSize), new string('_', midSize));
            for (var row = 1; row < n - 1; row++)
            {
                if (row < n - 1 - 1)
                {
                     Console.Write("|");
                     Console.Write(new string(' ', (n * 2) - 2));
                     Console.WriteLine("|");
                }

                else
                {
                    Console.Write("|");
                    Console.Write(new string(' ', colSize + 1));
                    Console.Write(new string('_', midSize));
                    Console.Write(new string(' ', colSize + 1));
                    Console.WriteLine("|");

                }
            }
            Console.WriteLine("\\{0}/{1}\\{0}/", new string('_', colSize), new string(' ', midSize));

        }
    }
}
