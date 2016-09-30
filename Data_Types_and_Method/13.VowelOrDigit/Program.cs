using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();
           
            if ("aeiou".Contains(str) || "AEIOU".Contains(str))
            {
                Console.WriteLine("vowel");
            }
            else if ("0123456789".Contains(str))
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
