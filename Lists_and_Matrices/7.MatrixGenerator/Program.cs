using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.MatrixGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sizeMatrix = Console.ReadLine().Split(' ').ToArray();

            int[,] matrix = new int[int.Parse(sizeMatrix[1]), int.Parse(sizeMatrix[2])];
            matrix = (ReadingMatrix(sizeMatrix));

        }
        static int[,] ReadingMatrix(string[] sizeMatrix)
        {
            int[,] matrix = new int[int.Parse(sizeMatrix[1]), int.Parse(sizeMatrix[2])];
            switch (sizeMatrix[0])
            {
                case "A":
                    for (int row = 1; row <= matrix.GetLength(0); row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            Console.Write(row + int.Parse(sizeMatrix[1]) * col + " ");
                        }
                        Console.WriteLine( );
                    }
                    break;
                case "B":
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            if (col % 2 == 0)
                            {
                                Console.Write(1 + row + int.Parse(sizeMatrix[1]) * col + " ");
                            }
                            if (col % 2 == 1)
                            {
                                Console.Write((col * int.Parse(sizeMatrix[1]) + int.Parse(sizeMatrix[1]) - row) + " ");
                            }                           
                        }
                        Console.WriteLine();
                    }
                    break;
                case "C":
                    
                    int number = 1;

                    for (int row = int.Parse(sizeMatrix[1]) - 1; row >= 0; row--)
                    {
                        int startR = row;
                        for (int col = 0; col < int.Parse(sizeMatrix[1]) - startR; col++)
                        {
                            if (col > int.Parse(sizeMatrix[2]) - 1)
                            {
                                break;
                            }
                            matrix[startR + col, col] = number;
                            number++;
                        }
                    }

                    for (int row = 1; row < int.Parse(sizeMatrix[2]); row++)
                    {
                        int startC = row;
                        for (int col = 0; col < int.Parse(sizeMatrix[2]) - startC; col++)
                        {
                            if (col > int.Parse(sizeMatrix[1]) - 1)
                            {
                                break;
                            }
                            matrix[col, startC + col] = number;
                            number++;
                        }
                    }
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            Console.Write(matrix[row, col] + " ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case "D":
                    
                    int number2 = 1;
                    int indexR = 0;
                    int indexC = 0;

                    while (number2 <= int.Parse(sizeMatrix[1]) * int.Parse(sizeMatrix[2]))
                    {
                        matrix[indexR, indexC] = number2;
                        number2++; ;

                        bool canGoDown = (indexR + 1) < int.Parse(sizeMatrix[1]) && matrix[indexR + 1, indexC] == 0 && !((indexC - 1) >= 0 && matrix[indexR, indexC - 1] == 0);
                        if (canGoDown)
                        {
                            indexR++;
                            continue;
                        }
                        bool canGoRight = (indexC + 1) < int.Parse(sizeMatrix[2]) && matrix[indexR, indexC + 1] == 0;
                        if (canGoRight)
                        {
                            indexC++;
                            continue;
                        }
                        bool canGoUp = (indexR - 1) >= 0 && matrix[indexR - 1, indexC] == 0;
                        if (canGoUp)
                        {
                            indexR--;
                            continue;
                        }
                        bool canGoLeft = (indexC - 1) >= 0 && matrix[indexR, indexC - 1] == 0;
                        if (canGoLeft)
                        {
                            indexC--;
                            continue;
                        }
                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write(matrix[row, col] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                    break;
            }
        
            return matrix;
        }
    }
}
