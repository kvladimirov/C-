using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            int[] arrays = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //int[] count = new int[arr.Max() + 1];
            //foreach (int ch in arr)
            //    count[ch]++;
            //for (int ch = 0; ch < count.Length; ch++)
            //    if (count[ch] != 0)
            //        Console.WriteLine($"{ch} -> {count[ch]}");


            //string str = Console.ReadLine().ToLower();
            //int[] count = new int[str.Max() + 1];
            //foreach (char ch in str)
            //    count[ch]++;
            //for (char ch = (char)0; ch < count.Length; ch++)
            //    if (count[ch] != 0)
            //        Console.WriteLine($"{ch} -> {count[ch]}");
            int[] smallArrays = arrays.Where(arr => arr <= 10 && arr >= 5).OrderBy(arr => arr).ToArray();
            //int[] smallArrays = arrays.Where(arr => arr <= 10).OrderBy(arr => -arr).Take(3).ToArray();
            //int[] smallArrays = arrays.Where(arr => arr <= 10).OrderBy(arr => arr % 2).Take(3).ToArray();
            List<string> namesP = names.Where(name => name[0] == 'P' && name.Contains("esho")).ToList();
            foreach (var smallArray in smallArrays)
            {
                Console.Write(smallArray);
            }
            
        }
    }
}
