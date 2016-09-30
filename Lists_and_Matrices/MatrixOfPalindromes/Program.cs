using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOfPalindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int matrixRows = cordinates[0];
            int matrixCols = cordinates[1];


            string[,] polidromesMatrix = new string[matrixRows, matrixCols];

            for (int row = 0; row < matrixRows; row++)
            {
                for (int col = 0; col < matrixCols; col++)
                {
                    polidromesMatrix[row, col] = "" + (char)('a' + row) + (char)('a' + row + col) + (char)('a' + row);


                }
            }

            for (int row = 0; row < matrixRows; row++)
            {
                for (int col = 0; col < matrixCols; col++)
                {
                    Console.Write(polidromesMatrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
