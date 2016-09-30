using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.FitStringIn20Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            List<string> stringIn20Chars = new List<string>();
            if (text.Length < 20)
            {
                Console.WriteLine(text.PadRight(20, '*'));
            }
            else
            {
                char[] arr = text.ToCharArray();

                arr = Array.FindAll<char>(arr, (c => (char.IsLetterOrDigit(c) || char.IsWhiteSpace(c) || c == '-')));
                text = new string(arr);

                Console.WriteLine(text.Substring(0, 20));
            }
        }
    }
}
