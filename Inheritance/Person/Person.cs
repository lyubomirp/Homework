using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    class Person
    {
        private string name;

        public virtual string Name
        {
            get { return name; }
            private set
            {
                if (value.Length < 3) { throw new ArgumentException("Name's length should not be less than 3 symbols!"); }
                name = value;
            }
        }

        private int age;

        public virtual int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age must be positive!");
                }
                else
                {
                    age = value;
                }

            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("Name: {0}, Age: {1}", this.Name, this.Age));

            return sb.ToString();
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}
