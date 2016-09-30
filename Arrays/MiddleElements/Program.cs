using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            //int mid = nums.Length / 2;

            //if (nums.Length == 1)
            //{
            //Console.WriteLine(nums[0]);
            //}
            //else if (nums.Length % 2 == 0)
            //{
            //Console.WriteLine($"{nums[mid - 1]}, {nums[mid]}");
            //}
            //else
            //{
            //Console.WriteLine($"{nums[mid - 1]}, {nums[mid]}, {nums[mid + 1]}");
            //}
            
                Console.WriteLine(string.Join(", ", ExtractMiddleElements(nums)));
        }
        static int[] ExtractMiddleElements(int[] nums)
        {
            int start = nums.Length / 2 - 1;
            int end = start + 2;
            if (nums.Length == 1) start = end = 0;
            if (nums.Length % 2 == 0) end--;           
            int[] mid = new int[end - start + 1];
            for (int i = start; i < end; i++)
            {
                mid[0] = nums[start];
                mid[1] = nums[end];

                nums = mid;
            }
            if (nums.Length % 2 == 1) end--; 
            

            
            
            
            
            return mid;
            
        }
    }
}
