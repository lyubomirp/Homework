using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace StudentGroups
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Town> towns = GetUserInput();
            OrderTownsAndPrint(towns);
        }

        static List<Town> GetUserInput()
        {
            char[] denum = { '=', '>' };

            string input = Console.ReadLine();

            int index = -1;

            List<Town> towns = new List<Town>();

            while (input != "End")
            {
                if (input.Contains("=>"))
                {
                    string[] splitInput = input.Split(denum, StringSplitOptions.RemoveEmptyEntries);
                    splitInput[0] = splitInput[0].Trim();
                    splitInput[1] = splitInput[1].Trim();

                    string[] seatCount = splitInput[1].Split();

                    index++;

                    Town newTown = new Town
                    {
                        Name = splitInput[0],
                        SeatsCount = int.Parse(seatCount[0]),
                        Students = new List<Student>()
                    };

                    towns.Add(newTown);
                } else
                {
                    OrganizeStudents(input, towns[index].Students);
                }

                input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
            }

            return towns;
        }



        static void OrganizeStudents(string input, List<Student>a)
        {
            char[] splitter = { '|' };

            string[] splitInput = input.Split(splitter, StringSplitOptions.RemoveEmptyEntries);

            splitInput[0]=splitInput[0].Trim();
            splitInput[1]=splitInput[1].Trim();
            splitInput[2]=splitInput[2].Trim();

            Student newStudent = new Student
            {
                Name = splitInput[0],
                Email = splitInput[1],
                RegistrationDate = DateTime.ParseExact("23-Jun-1993", "dd-MMM-yyyy", CultureInfo.InvariantCulture)
            };

            try
            {
                newStudent.RegistrationDate = DateTime.ParseExact(splitInput[2], "dd-MMM-yyyy", CultureInfo.InvariantCulture);
            } catch (FormatException)
            {
                newStudent.RegistrationDate = DateTime.ParseExact(splitInput[2], "d-MMM-yyyy", CultureInfo.InvariantCulture);
            }

            a.Add(newStudent);
        }


        static void OrderTownsAndPrint(List<Town> a)
        {
            List<Group> groups = new List<Group>();


            foreach(var town in a.OrderBy(x => x.Name))
            {

                town.Students = town.Students.OrderBy(x => x.RegistrationDate).ThenBy(x => x.Name).ThenBy(x => x.Email).ToList();

                while (town.Students.Any())
                {
                    Group newGroup = new Group
                    {
                        Town = town,
                        Students = town.Students.Take(town.SeatsCount).ToList()
                    };

                    town.Students = town.Students.Skip(town.SeatsCount).ToList();

                    groups.Add(newGroup);

                    if (!town.Students.Any())
                    {
                        break;
                    }
                }
            }

            Console.WriteLine($"Created {groups.Count()} groups in {a.Count} towns:");

            foreach(var group in groups)
            {
                Console.Write($"{group.Town.Name} => ");

                Console.WriteLine(string.Join(", ", group.Students.Select(x=>x.Email)));
            }
        }
    }



    class Town
    {
        public string Name
        {
            get;
            set;
        }

        public int SeatsCount
        {
            get;
            set;
        }

        public List<Student> Students
        {
            get;
            set;
        }
    }

    class Group
    {
        public Town Town
        {
            get;
            set;
        }

        public List<Student> Students
        {
            get;
            set;
        }
    }

    class Student
    {
        public string Name
        {
            get;
            set;
        }
        
        public string Email
        {
            get;
            set;
        }

        public DateTime RegistrationDate
        {
            get;
            set;
        }
    }
}
