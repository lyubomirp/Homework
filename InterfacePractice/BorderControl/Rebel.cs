using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    class Rebel : IIdentifiabl, IBuyable
    {
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        string name;
        int age;
        string group;
        int food;

        public Rebel(string name, int age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
        }

        public string Group
        {
            get
            {
                return group;
            }
            set
            {
                group = value;
            }
        }

        public int GetFood
        {
            get
            {
                return food;
            }
        }

        public void BuyFood()
        {
            food += 5;
        }

        public void SetStatus(string year)
        {
            throw new NotImplementedException();
        }
    }
}
