using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.PrimesInGivenRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            if (start > end)
            {
                Console.WriteLine("(empty list)");
            }
            else
            {
                Console.WriteLine(string.Join(", ", FindPrimesInRange(start, end)));
            }
        }
        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> result = new List<int>();
            for (int i = startNum; i <= endNum; i++)
            {            
              result.Add(i);
            }
            List<int> primeNumList = new List<int>();
            for (var i = 0; i < result.Count; i++)
            {
                if (PrimeChecker(result[i]) == true)
                {
                    primeNumList.Add(result[i]);
                }
            }
            return primeNumList;
        }
        static bool PrimeChecker(int num)
        {
            bool prime = true;

            if (num == 0 || num == 1)
            {
                prime = false;
            }

            for (var i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0 || num < 2)
                {
                    prime = false;
                    break;
                }
                else
                {
                    prime = true;
                }
            }
            return prime;
        }
    }
}
