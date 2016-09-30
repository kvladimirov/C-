using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> nums = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToList();
            string[] input = Console.ReadLine().Split(' ');
            decimal bomb = decimal.Parse(input[0]);
            while (nums.Contains(bomb))
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    if (bomb == nums[i])
                    {
                        int area = int.Parse(input[1]);
                        
                        nums.RemoveRange(Math.Max(0, i - area), Math.Min(2 * area + 1, nums.Count - Math.Max(0, i - area)));
                        break;
                    }

                }
            }
            Console.WriteLine(nums.Sum());
        }
    }
}
