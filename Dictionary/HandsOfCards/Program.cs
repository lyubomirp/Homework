using System;
using System.Collections.Generic;
using System.Linq;

namespace HandsOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] denum = { ' ', ':', '>', '&', '*', '/', '.', ',' };
            string[] cards = Console.ReadLine().Split(':');
            LettersToNumbers(cards);
        }

        static void LettersToNumbers(string[] cards)
        {
            char[] denum = { ' ', ':', '>', '&', '*', '/', '.', ',' };
            Dictionary<string, List<int>> final = new Dictionary<string, List<int>>();
            while (!(cards.Contains("JOKER")))
            {
                string playerName = cards[0];
                cards = cards[1].Split(denum, StringSplitOptions.RemoveEmptyEntries);
                int counter = 0;
                List<string> brokenString = new List<string>();
                for (int i = 0; i < cards.Length; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        if (cards[i].Length == 3)
                        {
                            brokenString.Add("10");
                            brokenString.Add(cards[i][j + 2].ToString());
                            break;
                        }
                        else
                        {
                            brokenString.Add(cards[i][j].ToString());
                        }
                    }
                }
                List<int> boi = brokenString
                    .Select(x => x.Replace("A", "14"))
                    .Select(x => x.Replace("J", "11"))
                    .Select(x => x.Replace("Q", "12"))
                    .Select(x => x.Replace("K", "13"))
                    .Select(x => x.Replace("S", "4"))
                    .Select(x => x.Replace("H", "3"))
                    .Select(x => x.Replace("D", "2"))
                    .Select(x => x.Replace("C", "1"))
                    .Select(int.Parse)
                    .ToList();

                int[] res = new int[boi.Count / 2];

                for (int i = 0; i < res.Length; i++)
                {
                    res[i] = boi[counter] * boi[counter + 1];

                    counter += 2;
                }

                if (final.ContainsKey(playerName))
                {
                    for (int i = 0; i < res.Length; i++)
                    {
                        final[playerName].Add(res[i]);
                    }
                }
                else
                {
                    final.Add(playerName, res.ToList());
                }


                cards = Console.ReadLine()
                .Split(':', StringSplitOptions.RemoveEmptyEntries);

                if (cards.Contains("JOKER"))
                {
                    foreach(var kvp in final)
                    {
                        Console.WriteLine($"{kvp.Key}: {kvp.Value.Distinct().Sum()}");
                    }
                }
            }
           
        }
    }
}



/*cards = cards.Distinct().ToArray();
List<string> brokenString = new List<string>();
List<string> broken = new List<string>();
int counter = 0;


                for (int i = 1; i<cards.Length; i++)
                {
                    for (int j = 0; j< 2; j++)
                    {
                        broken.Add(cards[i][j].ToString());
                    }
                }
                brokenString = broken
                    .Select(x => x.Replace("A", "14"))
                    .Select(x => x.Replace("J", "11"))
                    .Select(x => x.Replace("Q", "12"))
                    .Select(x => x.Replace("K", "13"))
                    .Select(x => x.Replace("S", "4"))
                    .Select(x => x.Replace("H", "3"))
                    .Select(x => x.Replace("D", "2"))
                    .Select(x => x.Replace("C", "1"))
                    .ToList();
int[] numbers = new int[brokenString.Count];

                for (int i = 0; i<brokenString.Count; i++)
                {
                    numbers[i] = int.Parse(brokenString[i]);
                }

                int[] finalSum = new int[numbers.Length / 2];

                for (int i = 0; i<finalSum.Length; i++)
                {

                    finalSum[i] = numbers[counter] * numbers[counter + 1];

counter += 2;
                }

                if (result.ContainsKey(cards[0]))
                {
                    result[cards[0]] += finalSum.Sum();
                }
                else
                {
                    result.Add(cards[0], finalSum.Sum());
                }

                cards = Console.ReadLine().Split(denum, StringSplitOptions.RemoveEmptyEntries);

                if (cards.Contains("JOKER"))
                {
                    foreach (var kvp in result)
                    {
                        Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                    }
                    break;
                }*/
