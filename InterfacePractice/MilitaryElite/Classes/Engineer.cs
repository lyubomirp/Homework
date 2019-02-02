using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Classes
{
    class Engineer : IEngineer
    {
        public List<Repairs> Repairs { get => repairs; set => repairs = value; }
        public string Corps { get => corps; set => corps = value; } 
        public double Salary { get => salary; set => salary = value; }
        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }

        List<Repairs> repairs;
        string corps;
        double salary;
        int id;
        string firstName;
        string lastName;

        public Engineer(List<Repairs> repairs, string corps, double salary, int id, string firstName, string lastName)
        {
            Repairs = repairs;
            Corps = corps;
            Salary = salary;
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Name: {0} Id: {1} Salary: {2:F2}{3}", firstName + " " + lastName, id, salary, Environment.NewLine);
            sb.AppendLine($"Corps: {corps}");
            sb.AppendLine($"Repairs:");

            foreach (var repair in repairs)
            {
                sb.Append($"  {repair.ToString()}");
            }

            return sb.ToString();
        }

    }
}
