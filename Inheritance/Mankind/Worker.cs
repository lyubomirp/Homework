using System;
using System.Collections.Generic;
using System.Text;

namespace Mankind
{
    class Worker : Human
    {
        private double weekSalary;

        public double WeekSalary
        {
            get { return weekSalary; }
            set
            {
                if (value <= 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }
                weekSalary = value;
            }
        }

        private double hoursPerDay;

        public double HoursPerDay
        {
            get { return hoursPerDay; }
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }
                hoursPerDay = value;
            }
        }

        public Worker(string firstName, string secondName, double weekSalary, double hours) : base(firstName, secondName)
        {
            WeekSalary = weekSalary;
            HoursPerDay = hours;
        }

        public string toString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"First Name: {this.FirstName}");
            sb.AppendLine($"Last Name: {this.SecondName}");
            sb.AppendLine($"Week Salary: {this.WeekSalary:F2}");
            sb.AppendLine($"Hours per day: {this.HoursPerDay:F2}");
            sb.AppendLine($"Salary per hour: {((this.WeekSalary)/(5*HoursPerDay)):F2}");

            return sb.ToString();
        }

    }
}
