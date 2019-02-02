using Animals.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    class Animal
    {
        InputChecker checker = new InputChecker();
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                checker.CheckInput(value);
                name = value;
            }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    throw new InvalidInput();
                }
                age = value;
            }
        }

        private string gender;

        public string Gender
        {
            get { return gender; }
            set
            {
                checker.CheckInput(value);
                gender = value;
            }
        }

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.GetType().Name);
            sb.AppendLine($"{name} {age} {gender}");

            return sb.ToString();
        }

    }
}
