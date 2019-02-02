using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    class Tomcat:Cat
    {
        public Tomcat(string name, int age, string gender) : base(name, age, gender)
        {
        }

        public Tomcat(string name, int age):this(name, age, "Male")
        {
        }

        public new void Sound()
        {
            Console.WriteLine("MEOW");
        }
    }
}
