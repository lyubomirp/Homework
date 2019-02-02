using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Classes
{
    class Commando : ICommando
    {
        public List<Mission> Missions { get => missions; set => missions=value; }
        public string Corps { get => corps; set => corps = value; }
        public double Salary { get => salary; set => salary = value; }
        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }

        List<Mission> missions;
        string corps;
        double salary;
        int id;
        string firstName;
        string lastName;

        public Commando(List<Mission> missions, string corps, double salary, int id, string firstName, string lastName)
        {
            Missions = missions;
            Corps = corps;
            Salary = salary;
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public void CompleteMission(List<Mission> missions, string missionName)
        {
            Mission toComplete = missions.Find(x => x.CodeName == missionName);

            toComplete.State = true;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Name: {0} Id: {1} Salary: {2:F2}{3}", firstName +" "+ lastName, id, salary, Environment.NewLine);
            sb.AppendLine($"Corps: {corps}");
            sb.AppendLine($"Missions:");

            foreach (var mission in missions)
            {
                sb.AppendLine($"  {mission.ToString()}");
            }

            return sb.ToString();
        }
    }
}
