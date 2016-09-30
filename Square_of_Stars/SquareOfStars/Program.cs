using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string initialRols = new String('*', num);
            string whiteSpaces = new String(' ', num - 2);

            Console.WriteLine(initialRols);

            for (int i = 0; i < num - 2; i++)
            {
                Console.Write("*");
                Console.Write(whiteSpaces);
                Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine(initialRols);
        }
    }
}
