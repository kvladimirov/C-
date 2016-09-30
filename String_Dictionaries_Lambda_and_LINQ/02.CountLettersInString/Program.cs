using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CountLettersInString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            int[] sum = new int[text.Max() + 1];
            foreach (char ch in text)
            {
                sum[ch]++;
            }

            for (char ch = (char)0; ch < sum.Length; ch++)
            {
                if (sum[ch] > 0)
                {
                    Console.WriteLine($"{ch} - > {sum[ch]}");
                }
            }
            
        }
    }
}
