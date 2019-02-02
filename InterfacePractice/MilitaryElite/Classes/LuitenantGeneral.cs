using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Classes
{
    class LuitenantGeneral : ILuitenantGeneral
    {
        public List<Private> Privates { get => privates; set => privates = value; }
        public double Salary { get => salary; set => salary = value; }
        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }

        List<Private> privates;
        double salary;
        int id;
        string firstName;
        string lastName;

        public LuitenantGeneral(List<Private> privates, double salary, int id, string firstName, string lastName) 
        {
            Privates = privates;
            Salary = salary;
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Name: {0} Id: {1} Salary: {2:F2}{3}", firstName + " " + lastName, id, salary, Environment.NewLine);
            sb.AppendLine($"Privates:");

            foreach (var dude in privates)
            {
                sb.Append($"  {dude.ToString()}");
            }

            return sb.ToString();
        }
    }
}
