using System;

namespace MordorCruelPlan
{
    class StartUp
    {
        static void Main(string[] args)
        {
            char[] denum = new char[] { ' ' };

            string[] input = Console.ReadLine().Split(denum, StringSplitOptions.RemoveEmptyEntries);

            int happyPoints = 0;

            for (int i = 0; i < input.Length; i++)
            {
                happyPoints += Food.GetFood(input[i]).happinessLevel;
            }

            Console.WriteLine(happyPoints);
            Console.WriteLine(Mood.GetMood(happyPoints).resMood);
        }
    }
}
