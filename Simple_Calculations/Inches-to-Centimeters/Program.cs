﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("inches = ");

            var inches = double.Parse(Console.ReadLine());
            var centimeters = inches * 2.54;

            Console.Write("Centimeters = ");
            Console.WriteLine(centimeters);
        }
    }
}
