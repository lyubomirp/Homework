using System;

namespace DateModifier
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string dateOne = Console.ReadLine();
            string dateTwo = Console.ReadLine();

            DateModifier.DateDifference(dateOne, dateTwo);

        }
    }
}
