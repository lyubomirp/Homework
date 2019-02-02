using System;

namespace Inheritance
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Student student = new Student("Guy Fieri", 1001, "dead");


            Console.WriteLine(student.ToString());
        }
    }
}
