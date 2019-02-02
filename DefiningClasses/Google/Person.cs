using System;
using System.Collections.Generic;
using System.Text;

namespace Google
{
    class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private Company company;

        public Company CompanyName
        {
            get { return company; }
            set { company = value; }
        }

        private List<Pokemon> pokemon;

        public List<Pokemon> Poke
        {
            get { return pokemon; }
            set { pokemon = value; }
        }

        private List<Parents> parents;

        public List<Parents> Parent
        {
            get { return parents; }
            set { parents = value; }
        }

        private List<Children> children;

        public List<Children> Kids
        {
            get { return children; }
            set { children = value; }
        }

        private Car car;

        public Car CurrentCar
        {
            get { return car; }
            set { car = value; }
        }




        public class Company
        {
            private string name;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            private string department;

            public string Department
            {
                get { return department; }
                set { department = value; }
            }

            private double salary;

            public double Salary
            {
                get { return salary; }
                set { salary = value; }
            }

        }
        public class Pokemon
        {
            private string name;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            private string type;

            public string Type
            {
                get { return type; }
                set { type = value; }
            }

            public Pokemon(string name, string type)
            {
                this.type = type;
                this.name = name;
            }
        }
        public class Parents
        {
            private string name;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            private string birthDay;

            public string Birthday
            {
                get { return birthDay; }
                set { birthDay = value; }
            }

            public Parents(string name, string birthday)
            {
                this.name = name;
                this.birthDay = birthday;
            }
        }
        public class Children
        {
            private string name;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            private string birthday;

            public string Birthday
            {
                get { return birthday; }
                set { birthday = value; }
            }

            public Children(string name, string birthday)
            {
                this.name = name;
                this.birthday = birthday;
            }
        }
        public class Car
        {
            private string model;

            public string Model
            {
                get { return model; }
                set { model = value; }
            }

            private double speed;

            public double Speed
            {
                get { return speed; }
                set { speed = value; }
            }
        }

        public string listResult(string typeToPrint)
        {
            string result = string.Empty;

            switch (typeToPrint)
            {
                case "pokemon":
                    {
                        foreach (var thing in pokemon)
                        {
                            result += thing.Name + " " + thing.Type + Environment.NewLine;
                        }
                    }
                    break;
                case "parents":
                    {
                        foreach (var guy in parents)
                        {
                            result += guy.Name + " " + guy.Birthday + Environment.NewLine;
                        }
                    }
                    break;
                case "kids":
                    {
                        foreach (var kid in children)
                        {
                            result += kid.Name + " " + kid.Birthday + Environment.NewLine;
                        }
                    }
                    break;
                case "company":
                    {
                        if (company.Salary <= 0)
                        {
                            result += string.Empty;
                        } else
                        {
                            result += $"{company.Name} {company.Department} {company.Salary:F2}" + Environment.NewLine;
                        }
                    }
                    break;
                case "car":
                    {
                        if (car.Speed<=0)
                        {
                            result += string.Empty;
                        }
                        else
                        {
                            result += $"{car.Model} {car.Speed}" + Environment.NewLine;
                        }
                    }
                    break;
            }

            return result;
        }
    }
}