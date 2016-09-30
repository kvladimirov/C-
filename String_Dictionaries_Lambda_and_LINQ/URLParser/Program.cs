using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLParser
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[] { ':', '/', };
            string input = Console.ReadLine();
            string[] inputSplitted = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int index1 = 0;
            int index2 = 0;
            if (input.IndexOf("://") != -1)
            {
                index1 = input.IndexOf("://");
                Console.WriteLine("[protocol] = \"{0}\"", input.Substring(0, index1));
                input = input.Remove(0, index1 + 3);
            }
            else
            {
                Console.WriteLine("[protocol] = \"\"");
            }

            if (input.IndexOf("/") != -1)
            {
                index2 = input.IndexOf("/");
                Console.WriteLine("[server] = \"{0}\"", input.Substring(0, index2));
                Console.WriteLine("[resource] = \"{0}\"", input.Substring(index2 + 1));
            }
            else
            {
                Console.WriteLine("[server] = \"{0}\"", input);
                Console.WriteLine("[resource] = \"\"");
            }
        }
    }
}
