using System;
using System.Linq;

namespace MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split()
                .Select(x => int.Parse(x))
                .ToArray();

            int[,] mainMatrix = new int[size[0], size[1]];
            int[][] sumMatrix = new int[][]
            {
                new int[3],
                new int[3],
                new int[3]
            };

            for (int i = 0; i < mainMatrix.GetLength(0); i++)
            {
                int[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => int.Parse(x))
                    .ToArray();

                for (int j = 0; j < input.Length; j++)
                {
                    mainMatrix[i, j] = input[j];
                }
            }

            int maxSumCol = 0;
            int currSumCol = 0;
            int[][] bestMatrixCol = new int[][]
            {
                new int[3],
                new int[3],
                new int[3]
            };

            for (int i = 0; i < mainMatrix.GetLength(0) - 2; i++)
            {
                for (int x = 0; x < mainMatrix.GetLength(1) - 2; x++)
                {
                    currSumCol = 0;

                    for (int j = 0; j < 3; j++)
                    {
                        for (int k = 0; k < 3; k++)
                        {
                            sumMatrix[k][j] = mainMatrix[k+i, j+x];
                        }
                    }

                    foreach (var array in sumMatrix)
                    {
                        foreach (var num in array)
                        {
                            currSumCol += num;
                        }
                    }

                    if (currSumCol > maxSumCol)
                    {
                        maxSumCol = currSumCol;

                        for (int q = 0; q < sumMatrix.Length; q++)
                        {
                            for (int z = 0; z < sumMatrix.Length; z++)
                            {
                                bestMatrixCol[z][q] = sumMatrix[z][q];
                            }
                        }
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSumCol}");

            foreach (var array in bestMatrixCol)
            {
                foreach (var num in array)
                {
                    Console.Write($"{num} ");
                }
                Console.WriteLine();
            }
        }
    }
}
