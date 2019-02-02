using System;
using System.Collections.Generic;
using System.Linq;

namespace Google
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            List<Person> people = new List<Person>();

            while (input[0] != "End")
            {
                Person person = new Person();
                person.Name = input[0];
                person.CompanyName = new Person.Company();
                person.CurrentCar = new Person.Car();
                person.Kids = new List<Person.Children>();
                person.Parent = new List<Person.Parents>();
                person.Poke = new List<Person.Pokemon>();

                if (people.Any(x => x.Name == input[0]))
                {
                    person = people.Find(x => x.Name == input[0]);
                    switch (input[1])
                    {
                        case "company":
                            person.CompanyName = new Person.Company();
                            person.CompanyName.Name = input[2];
                            person.CompanyName.Department = input[3];
                            person.CompanyName.Salary = double.Parse(input[4]);
                            break;
                        case "pokemon":
                            person.Poke.Add(new Person.Pokemon(input[2], input[3]));
                            break;
                        case "parents":
                            person.Parent.Add(new Person.Parents(input[2], input[3]));
                            break;
                        case "children":
                            person.Kids.Add(new Person.Children(input[2], input[3]));
                            break;
                        case "car":
                            person.CurrentCar = new Person.Car();
                            person.CurrentCar.Model = input[2];
                            person.CurrentCar.Speed = double.Parse(input[3]);
                            break;
                    }
                }
                else
                {

                    switch (input[1])
                    {
                        case "company":
                            person.CompanyName = new Person.Company();
                            person.CompanyName.Name = input[2];
                            person.CompanyName.Department = input[3];
                            person.CompanyName.Salary = double.Parse(input[4]);
                            break;
                        case "pokemon":
                            person.Poke = new List<Person.Pokemon>();
                            person.Poke.Add(new Person.Pokemon(input[2], input[3]));
                            break;
                        case "parents":
                            person.Parent = new List<Person.Parents>();
                            person.Parent.Add(new Person.Parents(input[2], input[3]));
                            break;
                        case "children":
                            person.Kids = new List<Person.Children>();
                            person.Kids.Add(new Person.Children(input[2], input[3]));
                            break;
                        case "car":
                            person.CurrentCar = new Person.Car();
                            person.CurrentCar.Model = input[2];
                            person.CurrentCar.Speed = double.Parse(input[3]);
                            break;
                    }
                }


                if (people.Any(x => x.Name == input[0]))
                {
                    people.Remove(people.Find(x => x.Name == input[0]));
                }
                people.Add(person);

                input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            string personToPrint = Console.ReadLine();

            Person toPrint = people.Find(x => x.Name == personToPrint);


                Console.Write($"{toPrint.Name}{Environment.NewLine}" +
                $"Company:{Environment.NewLine}" +
                $"{toPrint.listResult("company")}" +
                $"Car:{Environment.NewLine}" +
                $"{toPrint.listResult("car")}" +
                $"Pokemon:{Environment.NewLine}" +
                $"{toPrint.listResult("pokemon")}" +
                $"Parents:{Environment.NewLine}" +
                $"{toPrint.listResult("parents")}" +
                $"Children:{Environment.NewLine}" +
                $"{toPrint.listResult("kids")}");
        }
    }
}
