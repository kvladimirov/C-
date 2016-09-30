using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Palidnromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', '\t', ',', '?', '!', '.' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> list = new Dictionary<string, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (IsPalindrome(input[i]))
                {
                    if (list.ContainsKey(input[i]))
                    {
                        list[input[i]]++;
                    }
                    else
                    {
                        list[input[i]] = 1;
                    }
                }
            }

            Console.WriteLine(string.Join(", ", list.Keys.OrderBy(x => x)));
        }
        private static bool IsPalindrome(string word)
        {
            int rightIndex = word.Length - 1;
            int leftIndex = 0;
            while (rightIndex >= leftIndex)
            {
                if (word[rightIndex] != word[leftIndex])
                {
                    return false;
                }
                rightIndex--;
                leftIndex++;
            }
            return true;
        }//new char[] { ',', ':', '(', ')', '[', ']', '\"', '\'', '/', '\\', '!', '?', ';', ' ', '.', '-', '@', '#', '$', '%', '|', '&', '^', '_', '+', '~', '`', '<', '>', '*', '{', '}', '\t'}, StringSplitOptions.RemoveEmptyEntries
    }   
}
