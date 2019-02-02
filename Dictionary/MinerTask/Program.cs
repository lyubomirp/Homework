using System;
using System.Collections.Generic;

namespace MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> input = new Dictionary<string, int>();

            Ores(input);
        }


        static void Ores (Dictionary<string, int> a)
        {
            string resource = Console.ReadLine();
            int ammount = 0;
            while (!(resource=="stop"))
            {
                ammount = int.Parse(Console.ReadLine());
                
                if (a.ContainsKey(resource))
                {
                    a[resource] += ammount;
                }else
                {
                    a.Add(resource, ammount);
                }

                resource = Console.ReadLine();
            }
            foreach(var resources in a)
            {
                Console.WriteLine($"{resources.Key} -> {resources.Value}");
            }
        }
    }
}
