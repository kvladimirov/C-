using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            
            var largest3Nums = nums.OrderByDescending(x => x).Take(3);
            Console.WriteLine(string.Join(" ", largest3Nums));
        }
    }
}
