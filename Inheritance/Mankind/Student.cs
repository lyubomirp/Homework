using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mankind
{
    class Student : Human
    {
        private string facultyNumber;

        public string FacultyNumber
        {
            get { return facultyNumber; }
            set
            {
                if (value.Length < 5 || value.Length > 10 || !value.ToCharArray().All(char.IsLetterOrDigit))
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
                facultyNumber = value;
            }
        }
        
        public Student(string firstName, string secondName, string facultyNumber) : base(firstName, secondName)
        {
            FacultyNumber = facultyNumber;
        }
        

        public string toString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"First Name: {this.FirstName}");
            sb.AppendLine($"Last Name: {this.SecondName}");
            sb.AppendLine($"Faculty number: {this.FacultyNumber}");

            return sb.ToString();
        }
    }
}
