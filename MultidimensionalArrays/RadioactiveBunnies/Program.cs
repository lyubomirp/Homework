using System;
using System.Collections.Generic;
using System.Linq;

namespace RadioactiveBunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            char[][] lair = new char[dimensions[0]][];

            FillLair(lair, dimensions[1]);

            char[] moves = Console.ReadLine().ToCharArray();

            GameTime(lair, moves);


        }

        private static void GameTime(char[][] lair, char[] moves)
        {
            int[] player = new int[2];
            List<int> bunnies = new List<int>();

            for (int row = 0; row < lair.Length; row++)
            {
                for (int col = 0; col < lair[row].Length; col++)
                {
                    if(lair[row][col] == 'P')
                    {
                        player[0] = row;
                        player[1] = col;
                    } else if (lair[row][col] == 'B')
                    {
                        bunnies.Add(row);
                        bunnies.Add(col);
                    }
                }
            }

            int bunnyCount = bunnies.Count / 2;

            for (int turns = 0; turns < moves.Length; turns++)
            {
                switch (moves[turns])
                {
                    case "U":
                        try
                        {
                            lair[player[0] - 1][player[1]] = lair[player[0]][player[1]];
                        } catch (IndexOutOfRangeException)
                        {
                            Console.WriteLine($"won: {player[0]-1} {player[1]}");
                        }

                }
            }
        }

        private static void Print(char[][] lair)
        {
            foreach(var array in lair)
            {
                Console.WriteLine(string.Join("", array));
            }
        }

        private static void FillLair(char[][] lair, int v)
        {
            for (int row = 0; row < lair.Length; row++)
            {
                lair[row] = Console.ReadLine().ToCharArray();
            }
        }
    }
}
