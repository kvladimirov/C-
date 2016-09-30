using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Basein
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            var sum = (p1 + p2) * h;

            if (sum <= v)
            {
                var capV = Math.Floor((sum / v) * 100);
                var p1V = Math.Floor(((p1 * h) / sum) * 100);
                var p2V = Math.Floor(((p2 * h) / sum) * 100);
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", capV, p1V, p2V);
            }

            if (sum > v)
            {
                var div = sum - v;
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", h, div);
            }
        }
    }
}
