using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split(' ');
            List<int> currNums = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int num = int.Parse(nums[i]);
                int result = 0;
                while (num > 0)
                {
                    result = result * 10 + num % 10;
                    num /= 10;
                }
                currNums.Add(result);
            }
            
            Console.WriteLine(currNums.Sum());
        }
    }
}
