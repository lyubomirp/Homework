using System;
using System.Collections.Generic;
using System.Linq;

namespace Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());


            string[] commands = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);


            char[][] field = new char[fieldSize][];
            FillErUp(field);

            PlayIt(field, commands);
        }

        private static void PlayIt(char[][] field, string[] commands)
        {
            List<int> playerPos = FindPlayer(field);
            int coalCount = 0;
            bool hasDied = false;

            for (int i = 0; i < field.Length; i++)
            {
                for (int j = 0; j < field[i].Length; j++)
                {
                    if(field[i][j] == 'c')
                    {
                        coalCount++;
                    }
                }
            }

            for (int i = 0; i < commands.Length; i++)
            {
                switch (commands[i])
                {
                    case "up":
                        try
                        {
                            field[playerPos[0]][playerPos[1]] = '*';

                            if(field[playerPos[0] - 1][playerPos[1]] == 'c')
                            {
                                coalCount--;
                            }
                            if(field[playerPos[0] - 1][playerPos[1]] == 'e')
                            {
                                hasDied = true;
                                Console.WriteLine($"Game over! ({playerPos[0] - 1}, {playerPos[1]/2})");
                            }

                            field[playerPos[0] - 1][playerPos[1]] = 's';
                            playerPos[0] = playerPos[0] - 1;
                            
                        }
                        catch (IndexOutOfRangeException)
                        {

                        }
                        break;
                    case "down":
                        try
                        {
                            field[playerPos[0]][playerPos[1]] = '*';

                            if (field[playerPos[0] + 1][playerPos[1]] == 'c')
                            {
                                coalCount--;
                            }
                            if (field[playerPos[0] + 1][playerPos[1]] == 'e')
                            {
                                hasDied = true;
                                Console.WriteLine($"Game over! ({playerPos[0] + 1}, {playerPos[1]/2})");
                            }

                            field[playerPos[0] + 1][playerPos[1]] = 's';
                            playerPos[0] = playerPos[0] + 1;

                        }
                        catch (IndexOutOfRangeException)
                        {

                        }
                        break;
                    case "left":
                        try
                        {
                            field[playerPos[0]][playerPos[1]] = '*';

                            if (field[playerPos[0]][playerPos[1]-2] == 'c')
                            {
                                coalCount--;
                            }
                            if (field[playerPos[0]][playerPos[1]-2] == 'e')
                            {
                                hasDied = true;
                                Console.WriteLine($"Game over! ({playerPos[0]}, {(playerPos[1]-2)/2})");
                            }

                            field[playerPos[0]][playerPos[1]-2] = 's';
                            playerPos[1] = playerPos[1] - 2;

                        }
                        catch (IndexOutOfRangeException)
                        {

                        }
                        break;
                    case "right":
                        try
                        {
                            field[playerPos[0]][playerPos[1]] = '*';

                            if (field[playerPos[0]][playerPos[1]+2] == 'c')
                            {
                                coalCount--;
                            }
                            if (field[playerPos[0]][playerPos[1]+2] == 'e')
                            {
                                hasDied = true;
                                Console.WriteLine($"Game over! ({playerPos[0]}, {(playerPos[1]+2)/2})");
                            }

                            field[playerPos[0]][playerPos[1]+2] = 's';
                            playerPos[1] = playerPos[1] + 2;
                        }
                        catch (IndexOutOfRangeException)
                        {

                        }
                        break;
                }

                if (hasDied)
                {
                    break;
                }
                if (coalCount <= 0)
                {
                    Console.WriteLine($"You collected all coals! ({playerPos[0]}, {playerPos[1] / 2})");
                }
            }

            if (coalCount > 0 && hasDied == false)
            {
                Console.WriteLine($"{coalCount} coals left. ({playerPos[0]}, {playerPos[1] / 2})");
            }
        }

        private static List<int> FindPlayer(char[][] field)
        {
            List<int> coords = new List<int>();

            for (int i = 0; i < field.Length; i++)
            {
                for (int j = 0; j < field[i].Length; j++)
                {
                    if(field[i][j] == 's')
                    {
                        coords.Add(i);
                        coords.Add(j);
                    }
                }
            }

            return coords;
        }

        private static void Print(char[][] field)
        {
            foreach (var arr in field)
            {
                Console.WriteLine(string.Join("", arr));
            }
        }

        private static void FillErUp(char[][] field)
        {
            for (int i = 0; i < field.Length; i++)
            {
                field[i] = Console.ReadLine().ToCharArray();
            }
        }
    }
}
