using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.EncodedAnswers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            char[] letters = new char[n];

            for (int i = 0; i < n; i++)
            {
                uint num = uint.Parse(Console.ReadLine());
                
                if (num % 4 == 0)
                {
                    letters[i] = 'a';
                }
                else if (num % 4 == 1)
                {
                    letters[i] = 'b';
                }
                else if (num % 4 == 2)
                {
                    letters[i] = 'c';
                }
                else
                {
                    letters[i] = 'd';
                }
                
            }

            
            var counts = new int[letters.Max() + 1];
            foreach (var i in letters)
            {
                counts[i]++;
            }

            Console.WriteLine(string.Join(" ", letters));

            for (int k = 0; k < letters.Length; k++)
            {
                if (counts[k] > 0)
                {
                    
                    Console.WriteLine($"Answer {(char)(k - 32)}: {counts[k]}");
                }
                
            }                                     
        }
    }
}
