using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        public List<Person> people = new List<Person>();


        public void AddMember(Person person)
        {
            people.Add(person);
        }

        public void GetOldestMember()
        {
            List<Person> oldDudes = people.Where(x=>x.Age>30).OrderBy(x=>x.Name).ToList();

            foreach (var guy in oldDudes)
            {
                Console.WriteLine($"{guy.Name} - {guy.Age}");
            }
        }
    }

    
}
