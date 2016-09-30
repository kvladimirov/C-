using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBetweenPoints
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Name { get; set; }
        
    }

    class DistanceBetweenPoints
    {
        static void Main()
        {
            Point p1 = ReadPoint();
            Point p2 = ReadPoint();
            var dist = CalcDistance(p1, p2);
            Console.WriteLine("{0:f3}", dist);
        }

        private static Point ReadPoint()
        {
            var coords = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var p = new Point { X = coords[0], Y = coords[1] };
            return p;
        }

        static double CalcDistance(Point p1, Point p2)
        {
            var a = p2.X - p1.X;
            var b = p2.Y - p1.Y;
            return Math.Sqrt(a * a + b * b);
        }
    }
}
