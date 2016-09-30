using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ExtractSentencesBKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string[] text = Console.ReadLine().Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> list = new List<string>();
            for (int i = 0; i < text.Length; i++)
            {
                List<string> currentText = text[i].Split(new char[] { ',', ':', '(', ')', '[', ']', '\"', '\'', '/', '\\', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                if (currentText.Contains(word))
                {
                    list.Add(text[i]);
                }
            }
            foreach (var item in list)
            {
                Console.WriteLine(item.Trim());
            } 
        }
    }
}
