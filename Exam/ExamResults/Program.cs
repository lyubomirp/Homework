using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, int> studentAndScore= new Dictionary<string, int>();
            Dictionary<string, int> submissionsCount = new Dictionary<string, int>();

            while(input!= "exam finished")
            {
                string[] splitInput = input.Split('-', StringSplitOptions.RemoveEmptyEntries);

                if (splitInput.Length > 2)
                {
                    if (studentAndScore.ContainsKey(splitInput[0]))
                    {
                        if(studentAndScore[splitInput[0]] < int.Parse(splitInput[2]))
                        {
                            studentAndScore[splitInput[0]] = int.Parse(splitInput[2]);
                        }
                    } else
                    {
                        studentAndScore.Add(splitInput[0], int.Parse(splitInput[2]));
                    }

                    if (submissionsCount.ContainsKey(splitInput[1]))
                    {
                        submissionsCount[splitInput[1]]++;
                    } else
                    {
                        submissionsCount.Add(splitInput[1], 1);
                    }
                } else
                {
                    studentAndScore.Remove(splitInput[0]);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Results:");
            foreach(var person in studentAndScore.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{person.Key} | {person.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var lang in submissionsCount.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{lang.Key} - {lang.Value}");
            }
        }
    }
}
