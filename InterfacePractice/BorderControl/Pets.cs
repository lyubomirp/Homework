using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    class Pets : IIdentifiabl
    {
        public string Name { get => name; set => name = value; }
        public string BirthDate { get => birthDate; set => birthDate = value; }
        public int Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        string name;
        string birthDate;

        public Pets(string name, string birth)
        {
            Name = name;
            BirthDate = birth;
        }

        public void SetStatus(string year)
        {
            if (birthDate.EndsWith(year))
            {
                Console.WriteLine(birthDate);
            }
        }
    }
}
