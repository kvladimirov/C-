using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Program
{
    static void Main(string[] args)
    {
        int[] firstCircle = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] secondCircle = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Point centerA = new Point()
        {
            X = firstCircle[0],
            Y = firstCircle[1],
        };

        Point centerB = new Point()
        {
            X = secondCircle[0],
            Y = secondCircle[1],
        };

        Circle A = new Circle()
        {
            Center = centerA,
            Radius = firstCircle[2],
        };

        Circle B = new Circle()
        {
            Center = centerB,
            Radius = secondCircle[2],
        };

        if (Intersect(A, B))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }

    static bool Intersect(Circle c1, Circle c2)
    {
        double distanceBetweenCenters = CalcDistance(c1.Center, c2.Center);
        double sumOfRadiuses = c1.Radius + c2.Radius;
        if (distanceBetweenCenters > sumOfRadiuses)
        {
            return false;
        }
        return true;
    }

    private static double CalcDistance(Point p1, Point p2)
    {
        var a = p1.X - p2.X;
        var b = p1.Y - p2.Y;
        var sum2 = a * a + b * b;
        var distance = Math.Sqrt(sum2);
        return distance;
    }
}

class Circle
{
    public Point Center { get; set; }
    public int Radius { get; set; }
}

class Point
{
    public int X { get; set; }
    public int Y { get; set; }
}


