using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaofFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var figures = Console.ReadLine();

            if (figures == "square")
            {
                var a = double.Parse(Console.ReadLine());
                var area = a * a;

                Console.WriteLine(Math.Round(area, 3));
            }
            if (figures == "rectangle")
            {
                var a = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());
                var area = a * b;

                Console.WriteLine(Math.Round(area, 3));
            }
            if (figures == "circle")
            {
                var r = double.Parse(Console.ReadLine());
                var area = Math.PI * r * r;

                Console.WriteLine(Math.Round(area, 3));
            }
            if (figures == "triangle")
            {
                var a = double.Parse(Console.ReadLine());
                var h = double.Parse(Console.ReadLine());
                var area = a * h / 2;

                Console.WriteLine(Math.Round(area, 3));
            }
        }
    }
}
