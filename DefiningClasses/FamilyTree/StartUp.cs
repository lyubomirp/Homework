using System;
using System.Collections.Generic;
using System.Linq;

namespace FamilyTree
{
    class StartUp
    {
        static List<Person> people;
        static List<string> relationships;
        static void Main(string[] args)
        {
            people = new List<Person>();
            relationships = new List<string>();
            string firstName = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "End")
            {
                if (!input.Contains("-"))
                {
                    AddMember(input);
                    input = Console.ReadLine();
                    continue;
                }

                relationships.Add(input);

                input = Console.ReadLine();
            }

            foreach (var connection in relationships)
            {
                string[] inputArgs = connection.Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries);

                Person parent = GetPerson(inputArgs[0]);
                Person child = GetPerson(inputArgs[1]);

                if (!parent.Children.Contains(child))
                {
                    parent.Children.Add(child);
                }

                if (!child.Parents.Contains(parent))
                {
                    child.Parents.Add(parent);
                }
            }

            Print(firstName);
        }

        private static void Print(string firstName)
        {
            Person main = GetPerson(firstName);

            Console.WriteLine($"{main.Name} {main.Birthdate}");
            Console.WriteLine($"Parents:");

            foreach (var parent in main.Parents)
            {
                Console.WriteLine($"{parent.Name} {parent.Birthdate}");
            }
            Console.WriteLine($"Children:");

            foreach (var child in main.Children)
            {
                Console.WriteLine($"{child.Name} {child.Birthdate}");
            }
        }

        private static Person GetPerson(string v)
        {
            if (v.Contains("/"))
            {
                return people.FirstOrDefault(x => x.Birthdate == v);
            }

            return people.FirstOrDefault(x => x.Name == v);
        }

        private static void AddMember(string input)
        {
            string[] inputInfo = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string name = inputInfo[0] + " " + inputInfo[1];
            string birthday = inputInfo[2];

            people.Add(new Person(name, birthday));
        }
    }
}
