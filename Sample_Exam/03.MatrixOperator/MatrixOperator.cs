using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MatrixOperator
{
    class MatrixOperator
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            
            int[][] matrix = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                matrix[row] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();                                               
            }
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] data = input.Split(' ');
                switch (data[0])
                {
                    case "remove":
                        switch (data[1])
                        {
                            case "positive":
                                switch (data[2])
                                {
                                    case "row":
                                        RemovePositiveNumsInMatrixRow(matrix, data[3]);                                                
                                        
                                        break;
                                    case "col":
                                        RemovePositiveNumsInMatrixCol(matrix, data[3]);
                                        break;
                                }
                                break;
                            case "negative":
                                switch (data[2])
                                {
                                    case "row":
                                        RemoveNegativeNumsInMatrixRow(matrix, data[3]);

                                        break;
                                    case "col":
                                        RemoveNegativeNumsInMatrixCol(matrix, data[3]);
                                        break;
                                }
                                break;
                            case "odd":
                                switch (data[2])
                                {
                                    case "row":
                                        RemoveOddNumsInMatrixRow(matrix, data[3]);
                                        break;
                                    case "col":
                                        RemoveOddNumsInMatrixCol(matrix, data[3]);
                                        break;
                                }
                                break;
                            case "even":
                                switch (data[2])
                                {
                                    case "row":
                                        RemoveEvenNumsInMatrixRow(matrix, data[3]);
                                        break;
                                    case "col":
                                        RemoveEvenNumsInMatrixCol(matrix, data[3]);
                                        break;
                                }
                                break;
                        }
                        break;
                    case "swap":
                        SwapRowInMatrix(matrix, data[1], data[2]);
                        break;
                    case "insert":
                        InsurtElementInRow(matrix, data[1], data);
                        break;
                }
                input = Console.ReadLine();
            }
            for (int row = 0; row < rows; row++)
            {                            
                Console.Write(string.Join(" ", matrix[row]));
                Console.WriteLine();
            }
        }

        private static void InsurtElementInRow(int[][] matrix, string v1, string[] data)
        {
            List<int> nums = new List<int>();
            for (int i = 2; i < data.Length; i++)
            {
                nums.Add(int.Parse(data[i]));
            }

            for (int mRow = int.Parse(v1); mRow <= int.Parse(v1); mRow++)
            {
                if (matrix.GetLength(0) > int.Parse(v1) && int.Parse(v1) >= 0)
                {
                    List<int> list = matrix[mRow].ToList();
                    list.InsertRange(0, nums);
                    matrix[mRow] = list.ToArray();
                }
                
            }
        }

        private static void SwapRowInMatrix(int[][] matrix, string v1, string v2)
        {
            if (matrix.GetLength(0) > 1 && matrix.GetLength(0) > int.Parse(v2) && int.Parse(v1) >= 0 && int.Parse(v2) >= 0)
            {
                List<int> temp = matrix[int.Parse(v1)].ToList();
                matrix[int.Parse(v1)] = matrix[int.Parse(v2)];
                matrix[int.Parse(v2)] = temp.ToArray();
            }
           
        }

        private static void RemoveEvenNumsInMatrixCol(int[][] matrix, string data)
        {
            for (int mRow = 0; mRow < matrix.GetLength(0); mRow++)
            {
                List<int> list = matrix[mRow].ToList();
                if (list.Count > int.Parse(data) && list[int.Parse(data)] % 2 == 0 && int.Parse(data) >= 0)
                {
                    list.RemoveAt(int.Parse(data));
                }
                matrix[mRow] = list.ToArray();
            }
        }

        private static void RemoveEvenNumsInMatrixRow(int[][] matrix, string data)
        {
            for (int mRow = int.Parse(data); mRow <= int.Parse(data); mRow++)
            {
                if (matrix.GetLength(0) > int.Parse(data) && int.Parse(data) >= 0)
                {
                    List<int> list = matrix[mRow].ToList();
                    list.RemoveAll(i => i % 2 == 0);
                    matrix[mRow] = list.ToArray();
                }
               
            }
        }

        private static void RemoveOddNumsInMatrixCol(int[][] matrix, string data)
        {
            for (int mRow = 0; mRow < matrix.GetLength(0); mRow++)
            {
                
                List<int> list = matrix[mRow].ToList();
                if (list.Count > int.Parse(data) && list[int.Parse(data)] % 2 == 1 && int.Parse(data) >= 0)
                {
                    list.RemoveAt(int.Parse(data));
                }
                matrix[mRow] = list.ToArray();
            }
        }

        private static void RemoveOddNumsInMatrixRow(int[][] matrix, string data)
        {
            for (int mRow = int.Parse(data); mRow <= int.Parse(data); mRow++)
            {
                if (matrix.GetLength(0) > int.Parse(data) && int.Parse(data) >= 0)
                {
                    List<int> list = matrix[mRow].ToList();
                    list.RemoveAll(i => i % 2 == 1);
                    matrix[mRow] = list.ToArray();
                }
               
            }
        }

        private static void RemoveNegativeNumsInMatrixCol(int[][] matrix, string data)
        {
            for (int mRow = 0; mRow < matrix.GetLength(0); mRow++)
            {
                List<int> list = matrix[mRow].ToList();
                if (list.Count > int.Parse(data) && list[int.Parse(data)] < 0 && int.Parse(data) >= 0)
                {
                    list.RemoveAt(int.Parse(data));
                }
                matrix[mRow] = list.ToArray();
            }
        }

        private static void RemoveNegativeNumsInMatrixRow(int[][] matrix, string data)
        {
            for (int mRow = int.Parse(data); mRow <= int.Parse(data); mRow++)
            {
                if (matrix.GetLength(0) > int.Parse(data) && int.Parse(data) >= 0)
                {
                    List<int> list = matrix[mRow].ToList();
                    list.RemoveAll(i => i < 0);
                    matrix[mRow] = list.ToArray();
                }
                
            }
        }

        private static void RemovePositiveNumsInMatrixCol(int[][] matrix, string data)
        {
            for (int mRow = 0; mRow < matrix.GetLength(0); mRow++)
            {
                List<int> list = matrix[mRow].ToList();
                if (list.Count > int.Parse(data) && list[int.Parse(data)] >= 0 && int.Parse(data) >= 0)
                {
                    list.RemoveAt(int.Parse(data));
                }
                
                matrix[mRow] = list.ToArray();
            }
        }

        private static void RemovePositiveNumsInMatrixRow(int[][] matrix, string data)
        {
            for (int mRow = int.Parse(data); mRow <= int.Parse(data); mRow++)
            {
                if (matrix.GetLength(0) > int.Parse(data) && int.Parse(data) >= 0)
                {
                    List<int> list = matrix[mRow].ToList();
                    list.RemoveAll(i => i >= 0);
                    matrix[mRow] = list.ToArray();
                }
                
            }         
        }
    }
}
