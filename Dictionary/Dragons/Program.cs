using System;
using System.Collections.Generic;
using System.Linq;

namespace Dragons
{
    class Program
    {
        static void Main(string[] args)
        {
            GetUserInput();
        }



        static void GetUserInput()
        {
            Dictionary<string, List<double>> firstRow = new Dictionary<string, List<double>>();
            Dictionary<string, Dictionary<string, List<int>>> secondRow = new Dictionary<string, Dictionary<string, List<int>>>();
            int dragonCount = int.Parse(Console.ReadLine());
            int damage = 0;
            int health = 0;
            int armor = 0;
            string[] inputDragons = new string[dragonCount];

            for (int i = 0; i < inputDragons.Length; i++)
            {
                inputDragons[i] = Console.ReadLine();

                string[] stats = inputDragons[i].Split();

                string type = stats[0];
                string name = stats[1];

                if (stats[2].Contains("null"))
                {
                    damage = 45;
                } else
                {
                    damage = int.Parse(stats[2]);
                }
                if (stats[3].Contains("null"))
                {
                    health = 250;
                }
                else
                {
                    health = int.Parse(stats[3]);
                }
                if (stats[4].Contains("null"))
                {
                    armor = 10;
                }
                else
                {
                    armor = int.Parse(stats[4]);
                }


                FillFirstRow(firstRow, type, damage, health, armor);
                FillSecondRow(secondRow, type, name, damage, health, armor);

                
            }

            FormatAndPrint(firstRow, secondRow);
        }

        static void FillFirstRow(Dictionary<string, List<double>> typeAndAverage, string dragonType, int damage, int health, int armor)
        {
            if (typeAndAverage.ContainsKey(dragonType))
            {
                typeAndAverage[dragonType].Add(damage);
                typeAndAverage[dragonType].Add(health);
                typeAndAverage[dragonType].Add(armor);
            } else
            {
                typeAndAverage.Add(dragonType, new List<double>(3));
                typeAndAverage[dragonType].Add(damage);
                typeAndAverage[dragonType].Add(health);
                typeAndAverage[dragonType].Add(armor);
            }
        }

        static void FillSecondRow(Dictionary<string, Dictionary<string, List<int>>> secondRow, string type, string dragonName, int damage, int health, int armor)
        {
            if (secondRow.ContainsKey(type))
            {
                if (secondRow[type].ContainsKey(dragonName))
                {
                    secondRow[type][dragonName][0]=damage;
                    secondRow[type][dragonName][1]=health;
                    secondRow[type][dragonName][2]=armor;
                } else
                {
                    secondRow[type].Add(dragonName, new List<int>());
                    secondRow[type][dragonName].Add(damage);
                    secondRow[type][dragonName].Add(health);
                    secondRow[type][dragonName].Add(armor);
                }
            } else
            {
                secondRow.Add(type, new Dictionary<string, List<int>>());
                secondRow[type].Add(dragonName, new List<int>());
                secondRow[type][dragonName].Add(damage);
                secondRow[type][dragonName].Add(health);
                secondRow[type][dragonName].Add(armor);
            }
        }

        static void FormatAndPrint (Dictionary<string, List<double>> firstRow, Dictionary<string, Dictionary<string, List<int>>> secondRow)
        {
            foreach(var type in secondRow) {
                List<int> damage = new List<int>();
                List<int> health = new List<int>();
                List<int> armor = new List<int>();

                foreach (var dragon in type.Value)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        damage.Add(dragon.Value[0]);
                        health.Add(dragon.Value[1]);
                        armor.Add(dragon.Value[2]);
                    }
                }
                Console.WriteLine($"{type.Key}::({damage.Average():F2}/{health.Average():F2}/{armor.Average():F2})");

                foreach (var name in type.Value.OrderBy(x=>x.Key))
                {
                    Console.WriteLine($"-{name.Key} -> damage: {name.Value[0]}, health: {name.Value[1]}, armor: {name.Value[2]}");
                }
            }
        }
    }
}
