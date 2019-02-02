using System;
using System.Collections.Generic;
using System.Linq;

namespace Rankings
{
    class Rankings
    {
        static void Main(string[] args)
        {
            char[] denum = new char[] { ':', '=', '>' };

            string[] contestAndPass = Console.ReadLine()
                .Split(denum, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, string> contests = new Dictionary<string, string>();
            
            while(contestAndPass[0] != "end of contests")
            {
                contests.Add(contestAndPass[0], contestAndPass[1]);

                contestAndPass = Console.ReadLine()
                .Split(denum, StringSplitOptions.RemoveEmptyEntries);
            }

            string[] participants = Console.ReadLine()
                .Split(denum, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, Dictionary<string, int>> users = new Dictionary<string, Dictionary<string, int>>();

            while(participants[0]!="end of submissions")
            {
                string contestName = participants[0];
                string password = participants[1];
                string user = participants[2];
                int score = int.Parse(participants[3]);

                if (contests.ContainsKey(contestName) && contests[contestName] == password)
                {
                    if (users.ContainsKey(user))
                    {
                        if (users[user].ContainsKey(contestName))
                        {
                            if(users[user][contestName] < score)
                            {
                                users[user][contestName] = score;
                            }
                        } else
                        {
                            users[user].Add(contestName, score);
                        }
                    } else
                    {
                        users.Add(user, new Dictionary<string, int>());
                        users[user].Add(contestName, score);
                    }
                }

                participants = Console.ReadLine()
                .Split(denum, StringSplitOptions.RemoveEmptyEntries);
            }

            int highestScore = 0;
            string bestStudent = string.Empty;

            foreach(var races in users)
            {
                int currentScore = 0;

                foreach(var scores in races.Value)
                {
                    currentScore += scores.Value;
                }

                if (currentScore > highestScore)
                {
                    highestScore = currentScore;
                    bestStudent = races.Key;
                }
            }

            Console.WriteLine($"Best candidate is {bestStudent} with total {highestScore} points.");

            Console.WriteLine("Ranking:");

            foreach(var person in users.OrderBy(x=>x.Key))
            {
                Console.WriteLine(person.Key);

                foreach(var contAndScore in person.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"#  {contAndScore.Key} -> {contAndScore.Value}");
                }
            }
        }
    }
}
