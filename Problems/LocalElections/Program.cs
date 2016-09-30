using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalElections
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int o = int.Parse(Console.ReadLine());
            var p = Console.ReadLine();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{new string('.', 13)}");
                if (i == o)
                {
                    if (p == "X" || p == "x")
                    {

                        Console.WriteLine("...+-----+...");
                        Console.WriteLine("...|.\\./.|...");
                        Console.WriteLine($"{i:00}.|..X..|...");
                        Console.WriteLine("...|./.\\.|...");
                        Console.WriteLine("...+-----+...");
                    }
                    if (p == "V" || p == "v")
                    {

                        Console.WriteLine("...+-----+...");
                        Console.WriteLine("...|\\.../|...");
                        Console.WriteLine($"{i:00}.|.\\./.|...");
                        Console.WriteLine("...|..V..|...");
                        Console.WriteLine("...+-----+...");

                    }

                }
                
                else
                {
                    
                    Console.WriteLine("...+-----+...");
                    Console.WriteLine("...|.....|...");
                    Console.WriteLine($"{i:00}.|.....|...");
                    Console.WriteLine("...|.....|...");
                    Console.WriteLine("...+-----+...");

                }
                
            }
            Console.WriteLine($"{new string('.', 13)}");
        }
    }
}
