﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.EnglishNameOfTheLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            PrintDigitName(number);
        }
        static void PrintDigitName(string num)
        {
            switch(num.Last())
            {
                case '0':
                    Console.WriteLine("zero");
                    break;
                case '1':
                    Console.WriteLine("one");
                    break;
                case '2':
                    Console.WriteLine("two");
                    break;
                case '3':
                    Console.WriteLine("three");
                    break;
                case '4':
                    Console.WriteLine("four");
                    break;
                case '5':
                    Console.WriteLine("five");
                    break;
                case '6':
                    Console.WriteLine("six");
                    break;
                case '7':
                    Console.WriteLine("seven");
                    break;
                case '8':
                    Console.WriteLine("eight");
                    break;
                case '9':
                    Console.WriteLine("nine");
                    break;
            }
        }
    }
}
