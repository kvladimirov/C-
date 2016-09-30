using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.HourglassSum
{
    class Program
    {
        static void Main(string[] args)
        {
            long[,] matrix = new long[6, 6];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] rowNums = Console.ReadLine().Split(' ').ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = int.Parse(rowNums[col]);
                }
            }
            long[,] hourglassMatrix = new long[3, 3];
            FindingHourglassSum(matrix);
        }

        static void FindingHourglassSum(long[,] matrix)
        {
            long[,] hourglassMatrix = new long[3, 3];
            long bestSum = long.MinValue;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    long currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                                        matrix[row + 1, col + 1] + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (currentSum > bestSum)
                    {
                        bestSum = currentSum;
                    }
                }
            }

            Console.WriteLine(bestSum);
        }
    }
}
