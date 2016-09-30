using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastKNumbersSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());
            var numbers = new long[n];
            numbers[0] = 1;
            for (int current = 0; current < numbers.Length; current++)
            {
                var backPositions = Math.Min(current, k);
                long sum = 0;
                for (int goingBack = current - backPositions; goingBack <= current; goingBack++)
                {
                    sum += numbers[goingBack];
                }
                numbers[current] = sum;
                Console.WriteLine(numbers[current]);
            }
        }
    }
}
