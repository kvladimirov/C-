using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int index = 0;
            int currentIndex = 0;
            var currentNum = 0;
            
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        currentIndex++;
                    }
                }
                if (currentIndex > index)
                {
                    index = currentIndex;
                    currentNum = nums[i];
                    
                }
                currentIndex = 0;
            }
            
            Console.WriteLine(currentNum);
        }
    }
}
