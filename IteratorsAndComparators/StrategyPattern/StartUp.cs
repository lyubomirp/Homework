using System;
using System.Collections.Generic;

namespace StrategyPattern
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedSet<Person> peopleByName = new SortedSet<Person>(new PersonByName());
            SortedSet<Person> peopleByAge = new SortedSet<Person>(new PersonByAge());

            for (int i = 0; i < n; i++)
            {
                string[] arguments = Console.ReadLine().Split();

                Person p = new Person(arguments[0], int.Parse(arguments[1]));
                peopleByName.Add(p);
                peopleByAge.Add(p);
            }

            Console.WriteLine(string.Join(Environment.NewLine, peopleByName));
            Console.WriteLine(string.Join(Environment.NewLine, peopleByAge));
        }
    }
}
