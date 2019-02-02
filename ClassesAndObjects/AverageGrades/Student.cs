using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AverageGrades
{
    class Student
    {
        public string Name { get; set; }
        public double[] Grades { get; set; }

        public Student(string name, double[] grades)
        {
            this.Name = name;
            this.Grades = grades;
        }

        public static void GradesAverage(List<Student> a)
        {
            foreach (var student in a.OrderBy(x => x.Name).ThenByDescending(x => x.Grades.Average()))
            {
                if (student.Grades.Average() >= 5.00)
                {
                    Console.WriteLine($"{student.Name} -> {student.Grades.Average():F2}");
                }
            }
        }
    }
}
