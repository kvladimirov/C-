using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02.Problem
{
    class ArraySlider
    {
        static void Main(string[] args)
        {
            BigInteger[] array = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Select(BigInteger.Parse).ToArray();
            string input = Console.ReadLine();
            long currentIndex = 0;
            while (input != "stop")
            {
                string[] data = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                long offset = long.Parse(data[0]);
                char operation = char.Parse(data[1]);
                BigInteger operand = BigInteger.Parse(data[2]);
                offset %= array.Length;
                currentIndex += offset;
                if (currentIndex >= array.Length)
                {
                    currentIndex %= array.Length;
                }
                else if (currentIndex < 0)
                {
                    currentIndex = array.Length + currentIndex;
                }

                switch (operation)
                {
                    case '+':
                        array[currentIndex] += operand;
                        break;
                    case '-':
                        array[currentIndex] -= operand;
                        if (array[currentIndex] < 0)
                        {
                            array[currentIndex] = 0;
                        }
                        break;
                    case '*':
                        array[currentIndex] *= operand;
                        break;
                    case '/':
                        array[currentIndex] /= operand;
                        break;
                    case '&':
                        array[currentIndex] &= operand;
                        break;
                    case '|':
                        array[currentIndex] |= operand;
                        break;
                    case '^':
                        array[currentIndex] ^= operand;
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("[{0}]", string.Join(", ", array));
        }
    }
}