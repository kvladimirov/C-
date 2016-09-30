using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrippleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ')
  .Select(int.Parse).ToArray();
            var haveSum = false;
            for (int i = 0; i < nums.Length; i++)
                for (int j = i + 1; j < nums.Length; j++)
                {
                    int a = nums[i];
                    int b = nums[j];
                    int sum = a + b;
                    if (nums.Contains(sum))
                    {
                        Console.WriteLine($"{a} + {b} == {sum}");
                        haveSum = true;
                    }


                }
            if (!haveSum)
            {
                Console.WriteLine("No");
            }
        }
    }
}
