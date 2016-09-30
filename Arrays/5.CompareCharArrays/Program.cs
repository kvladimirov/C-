using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] arr2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            int sum1 = 0;
            int sum2 = 0;
            
            bool equalArray = true;
            for (int i = 0; i < arr1.Length; i++)
            {
                sum1 += arr1[i];
            }
            for (int i = (char)0; i < arr2.Length; i++)
            {
                sum2 += arr2[i];
            }
           
            if (arr1.Length == arr2.Length && sum1 < sum2)
            {
                equalArray = true;
            }
            if (arr1.Length == arr2.Length && sum1 > sum2)
            {
                equalArray = false;
            }
            if (arr1.Length != arr2.Length && sum1 > sum2)
            {
                equalArray = false;
            }

            if (equalArray == true)
            {

                PrintArray(arr1);
                PrintArray(arr2);
            }
            else
            {
                PrintArray(arr2);
                PrintArray(arr1);
            }
        }

        private static void PrintArray(char[] arr)
        {
            for (int index = 0; index < arr.Length; index++)
            {
                
                Console.Write("{0}", arr[index]);
                
            }
            Console.WriteLine();
        }
    }
}
