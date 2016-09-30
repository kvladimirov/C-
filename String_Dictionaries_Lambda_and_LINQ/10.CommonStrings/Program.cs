using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CommonStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int count = a.Length;
            for (int i = 0; i < a.Length; i++)
            {
                if (b.Contains(a[i]))
                {
                    Console.WriteLine("yes");
                    return;
                }
                else
                {
                    count--;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("no");
            }

        }
    }
}
