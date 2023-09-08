using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_Assig3
{
    internal class Matrx_Sum
    {
        public static void rowSum()
        {
            int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

            Console.WriteLine("Matrix:");
            PrintMatrix(matrix);

            int rowCount = matrix.GetLength(0);
            int colCount = matrix.GetLength(1);
            Console.WriteLine("rowcount"+rowCount);
            Console.WriteLine("colcount" + colCount);

            int[] rowSums = new int[rowCount];

            for (int i = 0; i < rowCount; i++)
            {
                int sum = 0;

                for (int j = 0; j < colCount; j++)
                {
                    sum += matrix[i, j]; // Calculate the sum for the current row
                }

                rowSums[i] = sum;
            }

            Console.WriteLine("\nSum of each row:");
            for (int i = 0; i < rowCount; i++)
            {
                Console.WriteLine("Row"+(i+1) +":"+rowSums[i]);
            }
        }

        static void PrintMatrix(int[,] matrix)
        {
            int rowCount = matrix.GetLength(0);
            int colCount = matrix.GetLength(1);

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
