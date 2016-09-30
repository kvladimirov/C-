using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftRidht = (n - 1) / 2;
            if (n % 2 == 1)
            {
                Console.WriteLine("{0}*{0}", new string('-', leftRidht));
            }

            for (int row = 0; row < n / 2; row++)
            {
                int mid = row * 2 + n % 2;
                leftRidht = (n - mid - 2) / 2;
                Console.WriteLine("{0}*{1}*{0}", new string('-', leftRidht), new string('-', mid));
            }

            for (int row = n / 2 - 2; row >= 0; row--)
            {
                int mid = row * 2 + n % 2;
                leftRidht = (n - mid - 2) / 2;
                Console.WriteLine("{0}*{1}*{0}", new string('-', leftRidht), new string('-', mid));
            }

            leftRidht = (n - 1) / 2;
            if (n % 2 == 1 && n != 1)
            {
                Console.WriteLine("{0}*{0}", new string('-', leftRidht));
            }
        }
    }
}
