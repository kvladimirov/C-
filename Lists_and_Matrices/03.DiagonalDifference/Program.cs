using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            var matrix = new decimal[n, n];
            decimal firstDiagonal = 0;
            decimal secondDiagonal = 0;
            for (int row = 0; row < n; row++)
            {
                var cells = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = cells[col];
                    
                }
                   
            }
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (row == col)
                    {
                        firstDiagonal += matrix[row, col];
                    }
                    if (row + col + 1 == n)
                    {
                        secondDiagonal += matrix[row, col];
                    }
                }                
            }
            Console.WriteLine(Math.Abs(firstDiagonal - secondDiagonal));
        }
    }
}

