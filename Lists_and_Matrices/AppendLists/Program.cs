using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var lists = Console.ReadLine().Split('|');
            var result = new List<string>();
            for (int i = lists.Length - 1; i >= 0; i--)
            {
                var list = lists[i].Split(' ');
                foreach (var item in list)
                {
                    result.Add(item);
                   
                    
                }
                
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
