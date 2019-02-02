using System;

namespace Mankind
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] firstDude = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] secondDude = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            try
            {
                Student student = new Student(firstDude[0], firstDude[1], firstDude[2]);
                Worker worker = new Worker(secondDude[0], secondDude[1], double.Parse(secondDude[2]), double.Parse(secondDude[3]));

                Console.WriteLine(student.toString());
                Console.WriteLine(worker.toString());
            }
            catch(ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }

        }
    }
}
