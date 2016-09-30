using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeMatrix = int.Parse(Console.ReadLine());

            decimal[,] matrix = new decimal[sizeMatrix, sizeMatrix];
            matrix = (ReadingMatrix(sizeMatrix));
            List<int> input = Console.ReadLine().Split(new char[] { ' ', '-', '>'}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            input.Insert(0, 0);
            StartToDistance(matrix, input);
        }

        static void StartToDistance(decimal[,] matrix, List<int> input)
        {

            decimal distance = 0;

            for (int i = 0; i < input.Count - 1; i++)
            {

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    if (input[i] == row)
                    {

                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            if (input[i+1] == col)
                            {
                                distance += matrix[row, col];
                            }

                        }
                    }
                }
            }
                 
            Console.WriteLine(distance);          
        }

        static decimal[,] ReadingMatrix(int sizeMatrix)
        {
            decimal[,] matrix = new decimal[sizeMatrix, sizeMatrix];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] rowNums = Console.ReadLine().Split(' ').ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = decimal.Parse(rowNums[col]);
                }
            }
            return matrix;
        }
    }
}
