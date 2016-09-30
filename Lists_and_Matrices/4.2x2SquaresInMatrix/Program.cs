using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2x2SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizeMatrix = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            char[,] matrix = new char[sizeMatrix[0], sizeMatrix[1]];
            matrix = (ReadingMatrix(sizeMatrix));

            int squaresInMatrix = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {

                    if (matrix[row, col] == matrix[row, col + 1] &&
                       matrix[row, col + 1] == matrix[row + 1, col] &&
                       matrix[row + 1, col] == matrix[row + 1, col + 1])
                    {
                        squaresInMatrix++;
                    }
                }
            }
            Console.WriteLine(squaresInMatrix);
        }

        static char[,] ReadingMatrix(int[] sizeMatrix)
        {
            char[,] matrix = new char[sizeMatrix[0], sizeMatrix[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] rowNums = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowNums[col];
                }
            }
            return matrix;
        }
    }
}
