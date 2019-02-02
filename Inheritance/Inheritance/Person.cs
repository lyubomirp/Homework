using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Person
    {
        private int age;
        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        public Person (int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }


        public override string ToString()
        {
            if (age < 50)
            {
                return $"{name}, aged {age} is a faggot";
            } else
            {
                return $"{name}, aged {age} is an old faggot";
            }
        }

    }
}
