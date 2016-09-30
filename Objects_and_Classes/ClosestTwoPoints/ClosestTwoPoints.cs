using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosestTwoPoints
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Name { get; set; }

    }

    class ClosestTwoPoints
    {
        static void Main()
        {
            Point[] points = ReadArrayOfPoints();
            var closestPoints = FindClosestTwoPoints(points);
            Console.WriteLine("{0:f3}", CalcDistance(
               closestPoints[0], closestPoints[1]));
            PrintPoint(closestPoints[0]);
            PrintPoint(closestPoints[1]);

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
        static Point[] ReadArrayOfPoints()
        {
            var n = int.Parse(Console.ReadLine());
            var points = new Point[n];
            for (int i = 0; i < n; i++)
                points[i] = ReadPoint();
            return points;
        }
        static void PrintPoint(Point point)
        {
            Console.WriteLine("({0}, {1})", point.X, point.Y);
        }
        static Point[] FindClosestTwoPoints(Point[] points)
        {
            var minDistance = double.MaxValue;
            Point[] closestTwoPoints = null;
            for (int p1 = 0; p1 < points.Length; p1++)
                for (int p2 = p1 + 1; p2 < points.Length; p2++)
                {
                    var distance = CalcDistance(points[p1], points[p2]);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        closestTwoPoints = new Point[] {
          points[p1], points[p2] };
                    }
                }
            return closestTwoPoints;
        }

    }
}
