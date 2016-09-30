using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FallenInLove
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 0; row < n; row++)
            {
                int mid = n * 2 - row * 2;
                int left = row;
                Console.Write("#{0}#{1}#{2}", new string('~', left), new string('.', mid), new string('.', left));
                Console.WriteLine("{0}#{1}#{2}#", new string('.', left), new string('.', mid), new string('~', left));
            }

            for (int row = 1; row <= n + 1; row++)
            {
                int mid = (n + 1) - row;
                int left = 2 * row - 1;
                
                Console.Write("{0}#{1}#{2}", new string('.', left), new string('~', mid), new string('.', mid));
                Console.WriteLine("{0}#{1}#{2}", new string('.', mid), new string('~', mid), new string('.', left));
            }

            for (int row = 0; row < n; row++)
            {
                int left = 2 * n + 2;

                Console.Write("{0}#", new string('.', left));
                Console.WriteLine("#{0}", new string('.', left));
            }
        }
    }
}
