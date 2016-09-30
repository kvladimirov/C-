using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = nums.Length/4;
            int[] firstPart = new int[k];
            int[] secondPart = new int[k];
            int[] middlePart = new int[2 * k];

            for (int i = 0; i < k; i++)
            {
                firstPart[i] = nums[k-1-i];
            }

            for (int i = 0; i < k; i++)
            {
                secondPart[i] = nums[4*k - 1 - i];
            }

            for (int i = 0; i < 2*k; i++)
            {
                middlePart[i] = nums[k + i];
            }

            for (int i = 0; i < k; i++)
            {
                middlePart[i] += firstPart[i];           
                middlePart[k + i] += secondPart[i];                
            }

            
                Console.WriteLine(string.Join(" ", middlePart));
            
        }
    }
}
