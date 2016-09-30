
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numberOfDashesOnTheSides = (n - 1) / 2;
            if (n % 2 == 1)
            {
                Console.WriteLine("{0}*{0}", new string('-', numberOfDashesOnTheSides));
            }

            for (int row = 0; row < n / 2; row++)
            {
                int middleDashes = row * 2 + n % 2;
                numberOfDashesOnTheSides = (n - middleDashes - 2) / 2;
                Console.WriteLine("{0}*{1}*{0}", new string('-', numberOfDashesOnTheSides), new string('-', middleDashes));
            }

            for (int row = n / 2 - 2; row >= 0; row--)
            {
                int middleDashes = row * 2 + n % 2;
                numberOfDashesOnTheSides = (n - middleDashes - 2) / 2;
                Console.WriteLine("{0}*{1}*{0}", new string('-', numberOfDashesOnTheSides), new string('-', middleDashes));
            }

            numberOfDashesOnTheSides = (n - 1) / 2;
            if (n % 2 == 1 && n != 1)
            {
                Console.WriteLine("{0}*{0}", new string('-', numberOfDashesOnTheSides));
            }

        }
    }
}
