using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Classes
{
    class Private : IPrivate
    {
        public double Salary { get => salary; set => salary = value; }
        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }

        double salary;
        int id;
        string firstName;
        string lastName;

        public Private(double salary, int id, string firstName, string lastName)
        {
            Salary = salary;
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Name: {0} {1} Id: {2} Salary: {3:F2}{4}", firstName, lastName, id, salary, Environment.NewLine);

            return sb.ToString();
        }
    }
}
