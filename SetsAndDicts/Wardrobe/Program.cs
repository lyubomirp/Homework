using System;
using System.Collections.Generic;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int clothesCount = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < clothesCount; i++)
            {
                string[] colors = Console.ReadLine()
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string[] clothes = colors[1].Split(',', StringSplitOptions.RemoveEmptyEntries);

                string color = colors[0];


                if (wardrobe.ContainsKey(color))
                {
                    for (int j = 0; j < clothes.Length; j++)
                    {
                        if (wardrobe[color].ContainsKey(clothes[j]))
                        {
                            wardrobe[color][clothes[j]]++;
                        } else
                        {
                            wardrobe[color].Add(clothes[j], 1);
                        }
                    }
                } else
                {
                    wardrobe.Add(color, new Dictionary<string, int>());

                    for (int k = 0; k < clothes.Length; k++)
                    {
                        if (wardrobe[color].ContainsKey(clothes[k]))
                        {
                            wardrobe[color][clothes[k]]++;
                        } else
                        {
                            wardrobe[color].Add(clothes[k], 1);
                        }
                    }
                }
            }

            string[] articleToFind = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);


            foreach(var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");

                if(color.Key == articleToFind[0])
                {
                    foreach (var article in color.Value)
                    {
                        if(article.Key == articleToFind[1])
                        {
                            Console.WriteLine($"* {article.Key} - {article.Value} (found!)");
                        } else
                        {
                            Console.WriteLine($"* {article.Key} - {article.Value}");
                        }
                    }
                } else
                {
                    foreach (var article in color.Value)
                    {
                        Console.WriteLine($"* {article.Key} - {article.Value}");
                    }
                }  
            }
        }
    }
}
