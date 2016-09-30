using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        { 
            var first = Console.ReadLine().Split(' ').ToArray();
            var second = Console.ReadLine().Split(' ').ToArray();

            if (LargestCommonEnd(first, second) >= 0)
            {
                Console.WriteLine(LargestCommonEnd(first, second));
            }
                    
        }
        static int LargestCommonEnd(string[] first, string[] second)
        {
            var rightCount = 0;
            while (rightCount < first.Length && rightCount < second.Length)
            { 
                if (first[first.Length - rightCount - 1] == second[second.Length - rightCount - 1])
                {
                    rightCount++;
                }
                
                else
                {
                    break;
                }
            }
            while (rightCount < first.Length && rightCount < second.Length)
            {
                if (first[rightCount] == second[rightCount])
                {
                    rightCount++;
                }


                else
                {
                    break;
                }
            }

            return rightCount;
        }
    }
}
