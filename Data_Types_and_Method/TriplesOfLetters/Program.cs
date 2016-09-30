using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriplesOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (var i = 'a'; i < 'a' + n; i++)
                for (var j = 'a'; j < 'a' + n; j++)
                    for (var k = 'a'; k < 'a' + n; k++)
                        Console.WriteLine($"{(char)i}\u8445{(char)j}{(char)k}");
        }
    }
}