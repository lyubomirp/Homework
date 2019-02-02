using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Classes
{
    class SpecializedSoldier : ISpecializedSoldier
    {
        public string Corps { get => corps; set => corps = value;  }
        public double Salary { get => salary; set => salary = value; }
        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }

        string corps;
        double salary;
        int id;
        string firstName;
        string lastName;

        public SpecializedSoldier(string corps, double salary, int id, string firstName, string lastName)
        {
            Corps = corps;
            Salary = salary;
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
