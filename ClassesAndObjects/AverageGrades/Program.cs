using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = GetUserInput();
            Student.GradesAverage(students);
        }

        static List<Student> GetUserInput()
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                double[] grades = new double[input.Length-1];

                for (int j = 1; j < input.Length; j++)
                {

                    grades[j-1] = double.Parse(input[j]);
                }


                students.Add(new Student(input[0], grades));
            }

            return students;
        }
    }
}
