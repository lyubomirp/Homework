using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Student : Person
    {
        private string degree;
        public Student(string name, int age, string degree) : base(age, name)
        {
            this.degree = degree;

        }
    }
}
