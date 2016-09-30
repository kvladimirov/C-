using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Reverse_the_Words_in_a_Sentence
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[] { '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ' };
            string input = Console.ReadLine();
            ExtracWords(separators, input);
        }

        private static void ExtracWords(char[] separators, string input)
        {
            List<string> inputWords = input.Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();

            inputWords = (Reverse(inputWords)
                );

            List<string> sortedInputWords = new List<string>(inputWords);
            sortedInputWords.Sort((e1, e2) => e2.Length.CompareTo(e1.Length));

            List<string> separaitionSymbols = input.Split(sortedInputWords.ToArray(), StringSplitOptions.RemoveEmptyEntries).ToList();

            for (int print = 0; print < inputWords.Count; print++)
            {
                Console.Write(inputWords[print] + separaitionSymbols[print]);
            }
            Console.WriteLine();
        }

        private static List<string> Reverse(List<string> inputW)
        {
            string[] reversedWords = new string[inputW.Count];

            for (int iRev = 0; iRev < inputW.Count; iRev++)
            {
                reversedWords[iRev] = inputW[inputW.Count - 1 - iRev];
            }
            return reversedWords.ToList();
        }
    }
}
