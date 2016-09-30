using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointintheFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            if ((y == 0 && x >= 0 && x <= 3 * h) || (y == h && x >= 0 && x <= h) || (y == h && x >= 2 * h && x <= 3 * h) || (x == 0 && y >= 0 && y <= h) || (x == 3 * h && y >= 0 && y <= h) || (x == h && y >= h && y <= 4 * h) || (x == 2 * h && y >= h && y <= 4 * h) || (y == 4 * h && x >= h && x <= 2 * h))
            {
                Console.WriteLine("border");
            }
            else if (x < 0 || x > 3 * h || ((x >= 0 && x < h) && (y < 0 || y > h)) || ((x >= h && x <= 2 * h) && (y < 0 || y > 4 * h)) || ((x > 2 * h && x <= 3 * h) && (y < 0 || y > h)))
            {
                Console.WriteLine("outside");
            }

            else 
            {
                Console.WriteLine("inside");
            }
        }
    }
}
