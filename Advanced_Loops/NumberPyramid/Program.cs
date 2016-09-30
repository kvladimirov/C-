using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var num = 1;

            for (var row = 1; row <= 1; row++)
            {
                for (var col = 1; col <= row; col++)
                {
                    if (col > 1)
                    {
                        Console.Write(num);
                        Console.Write(" ");
                        num++;
                    }

                    if (num > n)
                    {
                        break;
                    }
                }
                Console.WriteLine(1);

                if (num > n)
                {
                    break;
                }
            
            }
        }
    }
}
