using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace StudentsAndComments
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = GetUserInput();

            SortedDictionary<string, Student> students = ParseUserInput(input);

            Student.PrintStudents(students);
        }


        public static string GetUserInput()
        {
            string input = Console.ReadLine();

            return input;
        }

        public static SortedDictionary<string,Student> ParseUserInput( string s)
        {
            SortedDictionary<string, Student> students = new SortedDictionary<string, Student>();

            while (s!="end of dates")
            {
                string[] info = s.Split();

                if (info.Length >= 2)
                {
                    Student anotherStudent = new Student()
                    {
                        Name = info[0],
                        Comments = new List<string>(),
                        Attendance = new List<DateTime>()
                    };
                    string[] attendance = new string[2];
                    attendance = info[1].Split(',');

                    foreach (var date in attendance)
                    {
                        anotherStudent.Attendance.Add(DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture));
                    }


                    if (!students.ContainsKey(info[0]))
                    {
                        students.Add(info[0], anotherStudent);
                    }
                    else
                    {
                        foreach (var date in anotherStudent.Attendance)
                        {
                            students[info[0]].Attendance.Add(date);
                        }
                    }
                } else
                {
                    Student anotherStudent = new Student()
                    {
                        Name = info[0],
                        Comments = new List<string>(),
                        Attendance = new List<DateTime>()
                    };
                    if (!students.ContainsKey(info[0]))
                    {
                        students.Add(info[0], anotherStudent);
                    }
                }

                s = Console.ReadLine();
                if (s=="end of dates")
                {
                    break;
                }
            }

            while (s!="end of comments")
            {
                string[] comments = s.Split('-', StringSplitOptions.RemoveEmptyEntries);

                if (students.ContainsKey(comments[0]))
                {
                    students[comments[0]].Comments.Add(comments[1]);
                }

                s = Console.ReadLine();
                if (s=="end of comments")
                {
                    break;
                }
            }

            return students;
        }
    }
    class Student
    {
        public string Name { get; set; }
        public List<string> Comments { get; set; }
        public List<DateTime> Attendance { get; set; }






        public static void PrintStudents(SortedDictionary<string, Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student.Key);
                Console.WriteLine("Comments:");
                foreach (var comment in student.Value.Comments)
                {
                    Console.WriteLine($"- {comment}");
                }
                Console.WriteLine("Dates attended:");
                foreach (var date in student.Value.Attendance.OrderBy(x => x.Date))
                {
                    Console.WriteLine($"-- {date.ToString("dd/MM/yyyy")}");
                }
            }
        }

    }
}
