using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int[] sumResult = new int[nums.Length];

            for (int i = 0; i < n; i++)
            {
                int lastElement = nums[nums.Length - 1];
                for (int j = nums.Length - 1; j > 0; j--)
                {
                    nums[j] = nums[j - 1];
                }
                nums[0] = lastElement;
                for (int k = 0; k < nums.Length; k++)
                {
                    sumResult[k] += nums[k];
                }
            }
            Console.WriteLine(string.Join(" ", sumResult));
        }
    } 
}
