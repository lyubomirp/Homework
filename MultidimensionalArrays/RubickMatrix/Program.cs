using System;
using System.Linq;

namespace RubickMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixProportions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            int row = matrixProportions[0];
            int column = matrixProportions[1];

            int commandCount = int.Parse(Console.ReadLine());

            int[][] rubickMatrix = new int[row][];

            FillMatrix(rubickMatrix, column);

            for (int i = 0; i < commandCount; i++)
            {
                string[] commands = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                int destination = int.Parse(commands[0]);
                int moves = int.Parse(commands[2]);


                switch (commands[1])
                {
                    case "up":
                        MoveUp(rubickMatrix, destination, moves%rubickMatrix.Length);
                        break;
                    case "down":
                        MoveDown(rubickMatrix, destination, moves % rubickMatrix.Length);
                        break;
                    case "left":
                        MoveLeft(rubickMatrix, destination, moves % rubickMatrix.Length);
                        break;
                    case "right":
                        MoveRight(rubickMatrix, destination, moves % rubickMatrix.Length);
                        break;
                }
                
            }
            int counter = 1;

            for (int j = 0; j < rubickMatrix.Length; j++)
            {
                for (int k = 0; k < rubickMatrix[j].Length; k++)
                {
                    if (rubickMatrix[j][k] == counter)
                    {
                        Console.WriteLine("No swap required");
                        counter++;
                    }
                    else
                    {
                        Rearrange(rubickMatrix, j, k, counter);
                        counter++;
                    }
                }
            }
        }

        private static void Rearrange(int[][] rubickMatrix, int j, int k, int counter)
        {
            int col = 0;
            int row = 0;

            for (int i = 0; i < rubickMatrix.Length; i++)
            {
                for (int q = 0; q < rubickMatrix[i].Length; q++)
                {
                    if(rubickMatrix[i][q] == counter)
                    {
                        rubickMatrix[i][q] = rubickMatrix[j][k];
                        rubickMatrix[j][k] = counter;
                        col = i;
                        row = q;
                    }
                }
            }

            Console.WriteLine($"Swap ({j}, {k}) with ({col}, {row})");
        }

        private static void MoveRight(int[][] rubickMatrix, int destination, int moves)
        {
            for (int j = 0; j < moves; j++)
            {
                int rightmostElement = rubickMatrix[destination][rubickMatrix.Length - 1];

                for (int i = rubickMatrix.Length - 1; i > 0; i--)
                {
                    rubickMatrix[destination][i] = rubickMatrix[destination][i - 1];
                }

                rubickMatrix[destination][0] = rightmostElement;
            }
           
        }

        private static void MoveLeft(int[][] rubickMatrix, int destination, int moves)
        {
            for (int j = 0; j < moves; j++)
            {
                int leftmostElement = rubickMatrix[destination][0];

                for (int i = 0; i < rubickMatrix.Length - 1; i++)
                {
                    rubickMatrix[destination][i] = rubickMatrix[destination][i + 1];
                }

                rubickMatrix[destination][rubickMatrix.Length - 1] = leftmostElement;
            }
            
        }

        private static void MoveUp(int[][] rubickMatrix, int destination, int moves)
        {
            for (int j = 0; j < moves; j++)
            {
                int firstElement = rubickMatrix[0][destination];

                for (int i = 0; i < rubickMatrix.Length - 1; i++)
                {
                    rubickMatrix[i][destination] = rubickMatrix[i + 1][destination];
                }

                rubickMatrix[rubickMatrix.Length - 1][destination] = firstElement;
            }
            
        }

        private static void MoveDown (int[][] matrix, int column, int moves)
        {
            for (int j = 0; j < moves; j++)
            {
                int lastElement = matrix[matrix.Length - 1][column];

                for (int i = matrix.Length - 1; i > 0; i--)
                {
                    matrix[i][column] = matrix[i - 1][column];
                }

                matrix[0][column] = lastElement;
            }
        }


        private static void FillMatrix(int[][] rubickMatrix, int column)
        {
            int counter = 1;
            for (int row = 0; row < rubickMatrix.Length; row++)
            {
                rubickMatrix[row] = new int[column];

                for (int col = 0; col < rubickMatrix[row].Length; col++)
                {
                    rubickMatrix[row][col] = counter++;
                }
            }
        }


        public static void Print (int[][] matrix)
        {
            foreach (var array in matrix)
            {
                foreach (var number in array)
                {
                    Console.Write(number + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
