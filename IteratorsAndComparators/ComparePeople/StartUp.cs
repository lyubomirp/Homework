using System;
using System.Collections.Generic;

namespace ComparePeople
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] arguments = input.Split();

                Person person = new Person(arguments[0], int.Parse(arguments[1]), arguments[2]);

                people.Add(person);

                input = Console.ReadLine();
            }

            int index = int.Parse(Console.ReadLine())-1;

            Person comparePerson = people[index];

            int equalCount = 0;

            foreach (var item in people)
            {
                if(item.CompareTo(comparePerson) == 0)
                {
                    equalCount++;
                }
            }

            if(equalCount == 1)
            {
                Console.WriteLine("No matches");
                Environment.Exit(0);
            }

            Console.WriteLine($"{equalCount} {people.Count-equalCount} {people.Count}");
        }
    }
}
