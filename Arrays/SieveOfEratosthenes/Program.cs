using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieveOfEratosthenes
    {
        class Program
        {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<int> primeNumbers = new List<int>();
            bool[] numbers = new bool[number + 1];
            for (int i = 1; i <= number; i++)
            {
                numbers[i] = true;
            }

            for (int currentNumber = 2; currentNumber < numbers.Length; currentNumber++)
            {
                if (numbers[currentNumber] == true)
                {
                    primeNumbers.Add(currentNumber);
                }
                for (int i = 2 * currentNumber; i < numbers.Length; i += currentNumber)
                {
                    numbers[2 * currentNumber] = false;
                }
                for (int i = 3 * currentNumber; i < numbers.Length; i += currentNumber)
                {
                    numbers[3 * currentNumber] = false;
                }
                for (int i = 5 * currentNumber; i < numbers.Length; i += currentNumber)
                {
                    numbers[5 * currentNumber] = false;
                }
                for (int i = 5 * currentNumber; i < numbers.Length; i += currentNumber)
                {
                    numbers[5 * currentNumber] = false;
                }
                for (int i = 7 * currentNumber; i < numbers.Length; i += currentNumber)
                {
                    numbers[7 * currentNumber] = false;
                }

                for (int i = 11 * currentNumber; i < numbers.Length; i += currentNumber)
                {
                    numbers[11 * currentNumber] = false;
                }

                for (int i = 13 * currentNumber; i < numbers.Length; i += currentNumber)
                {
                    numbers[13 * currentNumber] = false;
                }
                for (int i = 17 * currentNumber; i < numbers.Length; i += currentNumber)
                {
                    numbers[17 * currentNumber] = false;
                }
                for (int i = 19 * currentNumber; i < numbers.Length; i += currentNumber)
                {
                    numbers[19 * currentNumber] = false;
                }
               
            }
            foreach (var primeNumber in primeNumbers)
            {
                Console.WriteLine(primeNumber + " ");
            }
        }
    }
}
                    
