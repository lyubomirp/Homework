using System;
using System.Collections.Generic;
using System.Text;

namespace FamilyTree
{
    class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private List<Person> children;

        public List<Person> Children
        {
            get { return children; }
            set { children = value; }
        }

        private List<Person> parents;

        public List<Person> Parents
        {
            get { return parents; }
            set { parents = value; }
        }



        private string birthdate;

        public string Birthdate
        {
            get { return birthdate; }
            set { birthdate = value; }
        }

        public Person(string name, string birthday)
        {
            this.name = name;
            this.birthdate = birthday;
            this.Children = new List<Person>();
            this.Parents = new List<Person>();
        }

        public Person()
        {

        }
    }
}
