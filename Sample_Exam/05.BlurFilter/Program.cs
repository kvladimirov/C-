using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BlurFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            int blurAmount = int.Parse(Console.ReadLine());
            int[] data = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int matrixRows = data[0];
            int matrixCols = data[1];
            //int[] rowsOffset = new int[] { -1, -1, -1, 0, 0, 1, 1, 1 };
            //int[] colsOffset = new int[] { -1, 0, 1, -1, 1, -1, 0, 1 };

            long[,] matrix = new long[matrixRows, matrixCols];

            for (int row = 0; row < matrixRows; row++)
            {
                int[] columns = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int col = 0; col < matrixCols; col++)
                {
                    matrix[row, col] = columns[col]; 
                }
                
            }
            int[] cordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int wantedRow = cordinates[0];
            int wantedCol = cordinates[1];
            //matrix[wantedRow, wantedCol] += blurAmount;
            int startRow = Math.Max(0, wantedRow - 1);
            int endRow = Math.Min(matrixRows - 1, wantedRow + 1);
            int startCol = Math.Max(0, wantedCol - 1);
            int endCol = Math.Min(matrixCols - 1, wantedCol + 1);

            //(for (int i = 0; i < rowsOffset.Length; i++)
            //{
            //  int validRow = wantedRow + rowsOffset[i];
            //  int validCol = wantedCol + colsOffset[i];
            //  if (IsValidCoordinate(matrix, validRow, validCol))
            //  {
            //matrix[validRow, validCol] += blurAmount;
            //}
            //}
            for (int row = startRow; row <= endRow; row++)
            {
                for (int col = startCol; col <= endCol; col++)
                {
                    matrix[row, col] += blurAmount;
                }

            }

            for (int row = 0; row < matrixRows; row++)
            {
                for (int col = 0; col < matrixCols; col++)
                {
                    Console.Write("{0} ", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
        
        private static bool IsValidCoordinate(long[,] matrix, int wantedRow, int wantedCol)
        {
            if (wantedRow >= 0 && wantedRow < matrix.Length && wantedCol >= 0 && wantedCol < matrix.Length)
            {
                return true;
            }

            return false;
        }
    }
}
