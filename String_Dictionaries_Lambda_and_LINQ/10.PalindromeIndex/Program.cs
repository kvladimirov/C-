using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PalindromeIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            if (IsPalindrome(word))
            {
                Console.WriteLine("-1");
            }
            else
            {
                for (int i = 0; i < word.Length; i++)
                    if (IsPalindrome(word.Remove(i, 1)))
                    {
                        Console.WriteLine(i);
                        break;
                    }
            }
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
        }
    }
}
