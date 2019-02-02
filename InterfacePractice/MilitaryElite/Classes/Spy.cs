using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Classes
{
    class Spy : ISpy
    {
        public int CodeNumber { get => codeNumber; set => codeNumber = value; }
        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }

        int codeNumber;
        int id;
        string firstName;
        string lastName;

        public Spy(int code, int id, string firstName, string lastName)
        {
            CodeNumber = code;
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Name: {1} {2} Id: {0}{4}Code Number: {3}{4}", id, firstName, lastName, codeNumber, Environment.NewLine);

            return sb.ToString();
        }
    }
}
