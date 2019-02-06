using System;
using System.Collections.Generic;
using System.Linq;

namespace MOBAChallenger
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, int>> players = new Dictionary<string, Dictionary<string, int>>();

            while(input != "Season end")
            {
                string[] brokenInput = input
                .Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

                if (brokenInput[1] == "vs")
                {
                    var name = brokenInput[0];
                    var otherGuy = brokenInput[2];
                    bool equalPos = false;

                    if (players.ContainsKey(name) && players.ContainsKey(otherGuy))
                    {
                        foreach(var pos in players[otherGuy])
                        {
                            if (players[name].ContainsKey(pos.Key))
                            {
                                equalPos = true;
                                break;
                            }
                        }

                        if (equalPos)
                        {
                            if (players[name].Values.Sum() > players[otherGuy].Values.Sum())
                            {
                                players.Remove(otherGuy);
                            } else if (players[name].Values.Sum() < players[otherGuy].Values.Sum())
                            {
                                players.Remove(name);
                            }
                        }
                    }

                }else
                {
                    var playerName = brokenInput[0];
                    var position = brokenInput[1];
                    var skill = int.Parse(brokenInput[2]);

                    if (players.ContainsKey(playerName))
                    {
                        if (players[playerName].ContainsKey(position))
                        {
                            if (players[playerName][position] < skill)
                            {
                                players[playerName][position] = skill;
                            }
                        } else
                        {
                            players[playerName].Add(position, skill);
                        }
                    } else
                    {
                        players.Add(playerName, new Dictionary<string, int>());
                        players[playerName].Add(position, skill);
                    }
                }
                input = Console.ReadLine();
            }

            foreach(var player in players.OrderByDescending(x=>x.Value.Values.Sum()).ThenBy(x=>x.Key))
            {
                int sum = 0;

                foreach(var pos in player.Value)
                {
                    sum += pos.Value;
                }

                Console.WriteLine($"{player.Key}: {sum} skill");

                foreach(var position in player.Value.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
                {
                    Console.WriteLine($"- {position.Key} <::> {position.Value}");
                }
            }
        }
    }
}
