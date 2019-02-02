using System;
using System.Linq;

namespace MatrixSquares
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixDimensions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            string[,] matrix = new string[matrixDimensions[0], matrixDimensions[1]];

            for (int i = 0; i < matrixDimensions[0]; i++)
            {
                string[] letters = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i,j] = letters[j];
                }
            }

            bool firstRow = false;
            bool secRow = false;
            int equalCount = 0;

            for (int i = 0; i < matrix.GetLength(0)-1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1)-1; j++)
                {
                    if(matrix[i, j] == matrix[i, j + 1])
                    {
                        firstRow = true;
                        if(matrix[i,j] == matrix[i+1,j] && matrix[i, j+1] == matrix[i + 1, j + 1])
                        {
                            secRow = true;
                            equalCount++;
                        }
                    }
                }
            }

            Console.WriteLine(equalCount);
        }
    }
}
