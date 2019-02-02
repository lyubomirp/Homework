using System;
using System.Linq;
using System.Collections.Generic;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .ToLower()
                .Split();

            Dictionary<string, int> materials = new Dictionary<string, int>();
            materials.Add("shards", 0);
            materials.Add("fragments", 0);
            materials.Add("motes", 0);


            while (materials["shards"] < 251 || materials["fragments"] < 251 || materials["motes"] < 251)
            {

                for (int i = 1; i < input.Length; i += 2)
                {
                    if (materials["shards"] >= 250 || materials["fragments"] >= 250 || materials["motes"] >= 250)
                    {
                        break;
                    }
                    if (materials.ContainsKey(input[i]))
                    {
                        materials[input[i]] += int.Parse(input[i - 1]);   
                    }
                    else
                    {
                        materials.Add(input[i], int.Parse(input[i - 1]));
                    }
                }

                if (materials["motes"] >= 250)
                {
                    materials["motes"] -= 250;
                    Console.WriteLine("Dragonwrath obtained!");
                    break;

                }
                else if (materials["shards"] >= 250)
                {
                    materials["shards"] -= 250;
                    Console.WriteLine("Shadowmourne obtained!");
                    break;
                }
                else if (materials["fragments"] >= 250)
                {
                    materials["fragments"] -= 250;
                    Console.WriteLine("Valanyr obtained!");
                    break;
                }

                input = Console.ReadLine()
               .ToLower()
               .Split();
            }

            foreach (var mat in materials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                if (mat.Key == "motes" || mat.Key == "fragments" || mat.Key == "shards")
                {
                    Console.WriteLine($"{mat.Key}: {mat.Value}");
                }
            }
            foreach (var rest in materials.OrderBy(x => x.Key))
            {
                if (rest.Key == "motes" || rest.Key == "fragments" || rest.Key == "shards")
                {   
                } else
                {
                    Console.WriteLine($"{rest.Key}: {rest.Value}");
                }
            }
        }
    }
}
