using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DefiningClasses
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person() : this("No name", 1)
        {
        }

        public Person(int setAge) : this("No name", setAge)
        {
        }

        public Person(string setName, int setAge)
        {
            this.Name = setName;
            this.Age = setAge;
        }
    }
}
