using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.MaxSequenceOfIncreasingElements
{
    class Program
    {

        static void MaximalSequence(int[] maxSeq, out int index, out int length)
        {
            index = 0;
            length = 1;
            int maxIndex = 0;
            int maxLenght = 1;
            int currentLenght = 1;
            int prev = maxSeq[0];
            for (int i = 1; i < maxSeq.Length; i++)
            {
                if (prev == maxSeq[i] - 1)
                {
                    currentLenght++;
                }
                else
                {
                    if (currentLenght > maxLenght)
                    {
                        maxLenght = currentLenght;
                        maxIndex = i - 1;
                    }
                    currentLenght = 1;
                }
                prev = maxSeq[i];
                if (i == maxSeq.Length - 1)
                {
                    if (currentLenght > maxLenght)
                    {
                        maxLenght = currentLenght;
                        maxIndex = i;
                    }
                }
                index = maxIndex;
                length = maxLenght;
            }


        }

        static void Main(string[] args)
        {
            var maxSeq = Console.ReadLine().Split(' ').Select(int.Parse).ToArray(); 
            int index = 0;
            int length = 1;
            MaximalSequence(maxSeq, out index, out length);
            for (int i = index - length + 1; i <= index; i++)
            {
                Console.Write("{0} ", maxSeq[i]);
            }
            Console.WriteLine();
        }
    }
}
