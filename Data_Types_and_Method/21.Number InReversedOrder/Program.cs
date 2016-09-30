using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Number_InReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            PrintReversedDigit(number);
        }
        static void PrintReversedDigit(string num)
        {
            char[] charArray = num.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(string.Join("", charArray));
        } 
    }
}
