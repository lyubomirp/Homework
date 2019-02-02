using System;
using System.Collections.Generic;
using System.Linq;

namespace Teams
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = CreateTeams();

            PopulateTeams(teams);

            Print(teams);
        }



        public static List<Team> CreateTeams()
        {
            int n = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();


            for (int i = 0; i < n; i++)
            {
                string[] inputTeams = Console.ReadLine()
                    .Split('-', StringSplitOptions.RemoveEmptyEntries);

                Team currentTeam = new Team
                {
                    Name = inputTeams[1],
                    Creator = inputTeams[0],
                    Members = new List<string>()
                };

                bool exists = teams.Any(x => x.Name == inputTeams[1]);

                if (!exists)
                {
                    if (teams.Any(x => x.Creator == inputTeams[0]))
                    {
                        Console.WriteLine($"{inputTeams[0]} cannot create another team!");
                    } else
                    {
                        teams.Add(currentTeam);
                        Console.WriteLine($"Team {currentTeam.Name} has been created by {currentTeam.Creator}!");
                    }
                }
                else
                {
                    Console.WriteLine($"Team {currentTeam.Name} was already created!");
                }
            }

            return teams;
        }


        public static void PopulateTeams(List<Team> a)
        {
            string input = Console.ReadLine();

            while (input != "end of assignment")
            {
                char[] denum = { '-', '>' };
                string[] teamMembers = input.Split(denum, StringSplitOptions.RemoveEmptyEntries);

                bool exists = a.Any(x => x.Creator == teamMembers[0]);



                if (!exists)
                {
                    if (a.Any(x => x.Name == teamMembers[1]))
                    {
                        if (a.Any(x => x.Members.Contains(teamMembers[0])))
                        {
                            Console.WriteLine($"Member {teamMembers[0]} cannot join team {teamMembers[1]}!");
                        } else
                        {
                            a.Find(x => x.Name == teamMembers[1]).Members.Add(teamMembers[0]);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Team {teamMembers[1]} does not exist!");
                    }
                }
                else
                {
                    if (a.Any(x => x.Name == teamMembers[1]))
                    {
                        Console.WriteLine($"Member {teamMembers[0]} cannot join team {teamMembers[1]}!");

                    }
                    else
                    {
                        Console.WriteLine($"Team {teamMembers[1]} does not exist!");
                    }
                }
                input = Console.ReadLine();
                if (input == "end of assignment")
                {
                    break;
                }
            }
        }



        public static void Print(List<Team> result)
        {
            foreach (var member in result.OrderByDescending(x=>x.Members.Count).ThenBy(x=>x.Name))
            {
                if (member.Members.Count > 0)
                {
                    Console.WriteLine(member.Name);
                    Console.WriteLine($"- {member.Creator}");
                }

                foreach (var person in member.Members.OrderBy(x=>x))
                {
                    Console.WriteLine($"-- {person}");
                }
            }
            Console.WriteLine("Teams to disband:");
            foreach (var team in result.OrderBy(x=>x.Name))
            {
                if (team.Members.Count <= 0)
                {
                    Console.WriteLine(team.Name);
                }
            }
        }
    }


    class Team
    {
        public string Name
        {
            get;
            set;
        }

        public string Creator
        {
            get;
            set;
        }

        public List<string> Members
        {
            get;
            set;
        }
    }
}
