using System;
using System.Linq;

namespace DiagonalDiff
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            int[,] matrix = new int[matrixSize, matrixSize];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] matrixValues = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = matrixValues[j];
                }
            }

            int primaryDiagonal = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        primaryDiagonal += matrix[i, j];
                    }
                }
            }

            int secondaryDiagonal = 0;
            int index = matrix.GetLength(1)-1;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 1; j > 0; j--)
                {
                    secondaryDiagonal += matrix[i, index];
                    index--;
                }
            }

            Console.WriteLine(Math.Abs(primaryDiagonal-secondaryDiagonal));
        }
    }
}
