﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var squares = new List<int>();
            foreach (var num in nums)
            {
                if (Math.Sqrt(num) == (int)Math.Sqrt(num)) 
                {
                    squares.Add(num);
                    squares.Sort((a, b) => b.CompareTo(a));
                }
            }
            Console.WriteLine(string.Join(" ", squares));
        }
    }
}
