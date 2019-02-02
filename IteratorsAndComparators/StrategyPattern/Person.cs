using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class Person : IComparable<Person>
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        string name;
        int age;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        public int CompareTo(Person other)
        {
            int result = this.Name.CompareTo(other.Name);

            if (result == 0)
            {
                result = this.Age.CompareTo(other.Age);
            }

            return result;
        }


        public override string ToString()
        {
            return $"{this.Name} {this.Age}";
        }
    }
}
