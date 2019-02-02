using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public class Citizen:IPerson,IBirthable,IIdentifiable
    {
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Birthdate { get => birthdate; set => birthdate = value; }
        public string Id { get => id; set => id = value; }

        string name;
        int age;
        string id;
        string birthdate;


        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Birthdate = birthdate;
            this.Id = id;
        }
    }
}
