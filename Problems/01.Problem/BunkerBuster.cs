using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace _01.Problem
{
    class BunkerBuster
    {
        static void Main(string[] args)
        {
            int[] coordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = coordinates[0];
            int cols = coordinates[1];
            int[] rowsOffset = new int[] { -1, -1, -1, 0, 0, 1, 1, 1 };
            int[] colsOffset = new int[] { -1, 0, 1, -1, 1, -1, 0, 1 };

            List<List<int>> matrix = new List<List<int>>();

            for (int row = 0; row < rows; row++)
            {
                List<int> columns = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                matrix.Add(columns);
            }

            string input = Console.ReadLine();
            while (input != "cease fire!")
            {
                string[] data = input.Split(' ');
                int wantedRow = int.Parse(data[0]);
                int wantedCol = int.Parse(data[1]);
                int bomb = char.Parse(data[2]);
                matrix[wantedRow][wantedCol] -= bomb;
                bomb = (int)Math.Ceiling(bomb / 2.0);
                for (int i = 0; i < rowsOffset.Length; i++)
                {
                    int validRow = wantedRow + rowsOffset[i];
                    int validCol = wantedCol + colsOffset[i];
                    if (IsValidCoordinate(matrix, validRow, validCol))
                    {
                        matrix[validRow][validCol] -= bomb;
                    }
                }
                input = Console.ReadLine();
            }

            int bunkersBusted = 0;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (matrix[row][col] <= 0)
                    {
                        bunkersBusted++;
                    }
                }
            }
            Console.WriteLine("Destroyed bunkers: {0}", bunkersBusted);
            Console.WriteLine("Damage done: {0:p1}", bunkersBusted / (rows * cols * 1.0));

        }

        private static bool IsValidCoordinate(List<List<int>> matrix, int wantedRow, int wantedCol)
        {
            if (wantedRow >= 0 && wantedRow < matrix.Count && wantedCol >= 0 && wantedCol < matrix[0].Count)
            {
                return true;
            }

            return false;
        }
    }
}
