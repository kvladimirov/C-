using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.DressPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int dashes = 4 * n;

            Console.WriteLine("{0}.{0}.{0}", new string('_', dashes));

            for (int i = 0; i < 2 * n; i++) 
            {
                int stars = 2 + (3 * i);
                int left = ((12 * n) - (2 * stars)) / 3;// 7 + 5
              
                Console.WriteLine("{0}.{1}.{0}.{1}.{0}", new string('_', left), new string('*', stars));
            }

            for (int j = 0; j < n; j++)
            {
                int stars = 12 * n;

                Console.WriteLine(".{0}.", new string('*', stars));
            }

            for (int k = 0; k < n + 1; k++)
            {
                if (k == 0)
                {
                    Console.WriteLine("{0}{1}{0}", new string('.', 3 * n), new string('*', 6 * n + 2)); 
                }

                else
                {
                    int leftright = 3 * n;
                    int stars = 2 * leftright + 2;
                    Console.WriteLine("{0}{1}{0}", new string('_', leftright), new string('o', stars));
                }
            }

            for (int l = 0; l < 3 * n; l++) 
            {
                Console.WriteLine("{0}.{1}.{0}", new string('_', 3 * n - l), new string('*', 6 * n + 2 * l));
            }

            Console.WriteLine("{0}", new string('.', 12 * n + 2));
        }
    }
}








