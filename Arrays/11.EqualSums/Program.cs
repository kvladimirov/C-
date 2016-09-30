using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i <= nums.Length - 1; i++)
            {
                if (nums.Length == 1)
                {
                    Console.WriteLine(0);
                    return;
                }
                int sumLeft = 0;
                for (int j = 0; j <= i; j++)
                {
                    sumLeft += nums[j];
                }
                int sumRight = 0;
                for (int j = i; j < nums.Length; j++)
                {
                    sumRight += nums[j];
                }
                if (sumLeft == sumRight)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");           
        }
    }
}
