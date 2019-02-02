using System;

namespace EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            String firstName = Console.ReadLine();
            String LastName = Console.ReadLine();

            byte age = byte.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            ulong persID = ulong.Parse(Console.ReadLine());
            int employNum = int.Parse(Console.ReadLine());

            Console.WriteLine("First name: "+firstName);
            Console.WriteLine("Last name: "+LastName);
            Console.WriteLine("Age: "+age);
            Console.WriteLine("Gender: "+gender);
            Console.WriteLine("Personal ID: "+persID);
            Console.WriteLine("Unique Employee number: "+employNum);
        }
    }
}
