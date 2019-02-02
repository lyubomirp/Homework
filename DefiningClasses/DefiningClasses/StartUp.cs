using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int cycles = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < cycles; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                family.AddMember(new Person(input[0], int.Parse(input[1])));
            }

            family.GetOldestMember();
        }
    }
}
