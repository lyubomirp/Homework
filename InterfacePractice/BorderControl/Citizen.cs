using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    class Citizen : IIdentifiabl, IBuyable
    {
        private int age;
        private string name;
        string birthDate;
        string id;
        int food;

        public string Id
        {
            get { return id; }
            set
            {
                id = value;
            }
        }

        public string BirthDate
        {
            get { return birthDate; }
            set
            {
                birthDate = value;
            }
        }

        public int GetFood
        {
            get
            {
                return food;
            }
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        public Citizen(string name, int age, string id, string birth)
        {
            Name = name;
            Age = age;
            Id = id;
            BirthDate = birth;
        }

        public void SetStatus(string year)
        {
            if (birthDate.EndsWith(year))
            {
                Console.WriteLine(birthDate);
            }
        }


        public void BuyFood()
        {
            food += 10;
        }
    }
}
