using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.MaxPlatform3x3
{
    class Program
    {

        static void Main(string[] args)
        {
            long[] sizeMatrix = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            long[,] matrix = new long[sizeMatrix[0], sizeMatrix[1]];
            matrix = (ReadingMatrix(sizeMatrix));

            long[,] maxPlatform3x3 = new long[3, 3];
            FindingMaxPlatform(matrix);
        }

        static void FindingMaxPlatform(long[,] matrix)
        {
            long[,] maxPlatform = new long[3, 3];
            long bestSum = long.MinValue;
            int bestRow = 0;
            int bestCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    long currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                                        matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                                        matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (currentSum > bestSum)
                    {
                        bestSum = currentSum;
                        bestRow = row;
                        bestCol = col;
                    }
                }
            }

            Console.WriteLine(bestSum);
            for (int rowSave = bestRow; rowSave < bestRow + 3; rowSave++)
            {
                for (int colSave = bestCol; colSave < bestCol + 3; colSave++)
                {
                    Console.Write(matrix[rowSave, colSave] + " ");
                }
                Console.WriteLine();
            }
        }

        static long[,] ReadingMatrix(long[] sizeMatrix)
        {
            long[,] matrix = new long[sizeMatrix[0], sizeMatrix[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] rowNums = Console.ReadLine().Split(' ').ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = int.Parse(rowNums[col]);
                }
            }
            return matrix;
        }
    }
}

