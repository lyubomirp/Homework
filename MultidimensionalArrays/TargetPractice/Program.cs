using System;
using System.Collections.Generic;
using System.Linq;

namespace TargetPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .Select(x => int.Parse(x))
               .ToArray();

            int rows = input[0];
            int columns = input[1];

            char[] snakeString = Console.ReadLine().ToCharArray();

            int[] shotgunBlast = Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .Select(x => int.Parse(x))
               .ToArray();

            int mainShotRow = shotgunBlast[0];
            int mainShotCol = shotgunBlast[1];
            int shotRadius = shotgunBlast[2];

            char[][] staircase = new char[rows][];

            SnakeCrawl(staircase, rows, columns, snakeString);

            ShootEmUp(staircase, mainShotRow, mainShotCol, shotRadius);

            Rearange(staircase);

            Print(staircase);
        }

        private static void Rearange(char[][] staircase)
        {
            Queue<char> symbols = new Queue<char>(staircase.Length);

            for (int row = 0; row < staircase[0].Length; row++)
            {
                int counter = 0;

                for (int col = 0; col < staircase.Length; col++)
                {
                    if(staircase[col][row] != ' ')
                    {
                        symbols.Enqueue(staircase[col][row]);
                    } else
                    {
                        counter++;
                    }
                }

                for (int i = 0; i < counter; i++)
                {
                    staircase[i][row] = ' ';
                }

                for (int j = counter; j < staircase.Length; j++)
                {
                    staircase[j][row] = symbols.Dequeue();
                }
            }
        }

        private static void Print(char[][] staircase)
        {
            foreach (var array in staircase)
            {
                foreach (var letter in array)
                {
                    Console.Write(letter);
                }
                Console.WriteLine();
            }
        }

        private static void ShootEmUp(char[][] staircase, int mainShotRow, int mainShotCol, int shotRadius)
        {
            for (int i = 0; i < staircase.Length; i++)
            {
                for (int j = 0; j < staircase[i].Length; j++)
                {
                    bool isInside = Math.Pow((mainShotRow-i), 2) + Math.Pow((mainShotCol-j), 2) <= Math.Pow(shotRadius, 2);

                    if (isInside)
                    {
                        staircase[i][j] = ' ';
                    }
                }
            }
        }

        private static void SnakeCrawl(char[][] staircase, int rows, int columns, char[] snakeString)
        {
            int index = 0;

            for (int row = 0; row < staircase.Length; row++)
            {
                staircase[row] = new char[columns];
            }

            if (rows % 2 != 0)
            {
                for (int i = staircase.Length - 1; i >= 0; i--)
                {
                    if (i % 2 == 0)
                    {
                        for (int j = staircase[i].Length - 1; j >= 0; j--)
                        {
                            if (index > snakeString.Length - 1)
                            {
                                index = 0;
                            }

                            staircase[i][j] = snakeString[index];
                            index++;
                        }
                    }
                    else
                    {
                        for (int j = 0; j < staircase[i].Length; j++)
                        {
                            if (index > snakeString.Length - 1)
                            {
                                index = 0;
                            }
                            staircase[i][j] = snakeString[index];
                            index++;
                        }
                    }
                }
            }
            else
            {
                for (int i = staircase.Length - 1; i >= 0; i--)
                {
                    if (i % 2 != 0)
                    {
                        for (int j = staircase[i].Length - 1; j >= 0; j--)
                        {
                            if (index > snakeString.Length - 1)
                            {
                                index = 0;
                            }

                            staircase[i][j] = snakeString[index];
                            index++;
                        }
                    }
                    else
                    {
                        for (int j = 0; j < staircase[i].Length; j++)
                        {
                            if (index > snakeString.Length - 1)
                            {
                                index = 0;
                            }
                            staircase[i][j] = snakeString[index];
                            index++;
                        }
                    }
                }
            }
        }
    }
}
