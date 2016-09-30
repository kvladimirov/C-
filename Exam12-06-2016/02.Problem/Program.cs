using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            List<decimal> newList = new List<decimal>();
            decimal count = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                count += numbers[i];
            }
            decimal average = count / numbers.Count;
           
            newList = numbers.Where(n => n > average).OrderBy(n => -n).Take(5).ToList();

            if (newList.Count > 0)
            {
                foreach (var num in newList)
                {

                    Console.Write(num + " ");
                }
                

            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
