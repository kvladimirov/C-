using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace _04.Problem
{
    class ArrayModifier
    {
        static void Main(string[] args)
        {
            List<BigInteger> numbers = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToList();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] data = input.Split(' ');

                if (data[0] == "swap")
                {
                    int index1 = int.Parse(data[1]);
                    int index2 = int.Parse(data[2]);
                  
                    SwapInts(numbers, index1, index2);

                    
                }

                if (data[0] == "multiply")
                {
                    int index1 = int.Parse(data[1]);
                    int index2 = int.Parse(data[2]);
                    numbers[index1] = numbers[index1] * numbers[index2];
                }
                if (data[0] == "decrease")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {

                        numbers[i] -= 1;
                    }
                                                                
                }

                input = Console.ReadLine();
            }
            
            Console.Write(string.Join(", ", numbers));          
        }
        static void SwapInts(List<BigInteger> list, int position1, int position2)
        {
            BigInteger temp = list[position1];
            list[position1] = list[position2]; 
            list[position2] = temp; 
        }
    }
}
