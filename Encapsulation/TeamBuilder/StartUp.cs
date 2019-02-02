using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamBuilder
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            string[] input = Console.ReadLine().Split(';');

            while (input[0] != "END")
            {
                try
                {
                    switch (input[0])
                    {
                        case "Team":
                            Team newTeam = new Team(new List<Player>(), input[1]);
                            teams.Add(newTeam);
                            break;
                        case "Add":
                            Team teamToInc = CheckTeams(teams, input);
                            Player newPlayer = new Player(input[2], int.Parse(input[3]), int.Parse(input[4])
                                , int.Parse(input[5]), int.Parse(input[6]), int.Parse(input[7]));
                            teamToInc.AddPlayer(newPlayer);
                            break;
                        case "Remove":
                            Team teamToRem = CheckTeams(teams, input);
                            teamToRem.RemovePlayer(input[2], teamToRem);
                            break;
                        case "Rating":
                            Team team = CheckTeams(teams, input);
                            Console.WriteLine($"{team.Name} - {team.Rating}");
                            break;
                    }
                } catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                input = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            }
        }

        private static Team CheckTeams(List<Team> teams, string[] input)
        {
            if (teams.Any(x => x.Name == input[1]))
            {
                return teams.Find(x => x.Name == input[1]);
            }
            throw new ArgumentException($"Team {input[1]} does not exist.");
        }
    }
}
