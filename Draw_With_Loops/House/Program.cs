using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            

            for (int i = 1; i <= (n + 1) / 2; i++)
            {

                if (i == 1)
                {
                    if (n % 2 == 0)
                    {
                        int stars = 2;
                        int dashes = (n - stars) / 2;
                        Console.WriteLine("{0}{1}{0}", new string('-', dashes), new string('*', stars));
                    }

                    if (n % 2 == 1)
                    {
                        int stars = 1;
                        int dashes = (n - stars) / 2;
                        Console.WriteLine("{0}{1}{0}", new string('-', dashes), new string('*', stars));
                    }
                }

                else
                {
                    int stars = i * 2 - n % 2;
                    int dashes = (n - stars) / 2;
                    Console.WriteLine("{0}{1}{0}", new string('-', dashes), new string('*', stars));
                }
            }

            for (int i = n / 2; i > 0; i--)
            {
                int stars = n - 2;
                Console.WriteLine("|{0}|", new string('*', stars));
            }
        }
    }
}
