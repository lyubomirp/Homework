using System;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirdEmployee = int.Parse(Console.ReadLine());

            int studentsCount = int.Parse(Console.ReadLine());

            int studentsPerHr = firstEmployee + secondEmployee + thirdEmployee;

            long totalTime = 0;

            while (studentsCount > 0)
            {
                if (totalTime % 4 == 0)
                {
                    totalTime++;

                } else
                {
                    studentsCount -= studentsPerHr;

                    if (studentsCount <= 0)
                    {
                        break;
                    }

                    totalTime++;
                }

            }

            Console.WriteLine($"Time needed: {totalTime}h.");
        }
    }
}
