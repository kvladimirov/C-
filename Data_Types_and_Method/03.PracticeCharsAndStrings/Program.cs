using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PracticeCharsAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            char letter1 = char.Parse(Console.ReadLine());
            char letter2 = char.Parse(Console.ReadLine());
            char letter3 = char.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            Console.WriteLine(name);
            Console.WriteLine(letter1);
            Console.WriteLine(letter2);
            Console.WriteLine(letter3);
            Console.WriteLine(text);
        }
    }
}
