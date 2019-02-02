using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    class Kitten:Cat
    {
        public Kitten(string name, int age, string gender) : base(name, age, gender)
        {
        }

        public Kitten(string name, int age) : this(name, age, "Female")
        {
        }

        public new void Sound()
        {
            Console.WriteLine("Meow");
        }
    }
}
