using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.LargestIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] length = new int[numbers.Length];   // length of longest increasing subsequence (LIS) ending at index i
            int[] previous = new int[numbers.Length]; // index of the number preceding the number at index i
            int maxLength = 1;
            int endingIndex = 0;

            for (int currentIndex = 0; currentIndex < numbers.Length; currentIndex++)
            {
                length[currentIndex] = 1;
                previous[currentIndex] = -1;
                for (int prevIndex = 0; prevIndex <= currentIndex - 1; prevIndex++)
                    if (numbers[prevIndex] < numbers[currentIndex] && length[prevIndex] + 1 > length[currentIndex])
                    {
                        length[currentIndex] = 1 + length[prevIndex];
                        previous[currentIndex] = prevIndex;
                    }
                if (length[currentIndex] > maxLength)
                {
                    maxLength = length[currentIndex];
                    endingIndex = currentIndex;
                }
                // if several sequences of max length, keep the leftmost sequence, i.e. keep the lower endingIndex
                // if length[currentIndex] == maxLength => do not update endingIndex to currentIndex
            }
            List<int> longestIncreasingSequence = GetLongestIncreasingSequence(numbers, previous, endingIndex);
            Console.WriteLine(string.Join(" ", longestIncreasingSequence));
        }
        static List<int> GetLongestIncreasingSequence(int[] numbers, int[] previousIndex, int endingIndex)
        {
            List<int> longestSequence = new List<int>();
            while (endingIndex >= 0)
            {
                longestSequence.Add(numbers[endingIndex]);
                endingIndex = previousIndex[endingIndex];
            }
            longestSequence.Reverse();
            return longestSequence;
        }
    }
}
