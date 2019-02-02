using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SerbianUnleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] splitter = { ' ', '@' };
            string pattern = @"(\w+(?: \w+)*) @(\w+(?: \w+)*) (\d+) (\d+)";
            string input = Console.ReadLine();
            VenueCalc(input);
        }



        static void VenueCalc(string b)
        {
            char[] splitter = { ' ', '@' };
            Dictionary<string, Dictionary<string, long>> output = new Dictionary<string, Dictionary<string, long>>();
            string pattern = @"(\w+(?: \w+)*) @(\w+(?: \w+)*) (\d+) (\d+)";
            while (b != "End")
            {
                if (Regex.IsMatch(b, pattern))
                {
                    string artistName = string.Empty;
                    string venueName = string.Empty;
                    long ticketPrice = 0;
                    long ticketCount = 0;

                    string[] a = b.Split();
                    for (int i = 0; i < a.Length; i++)
                    {
                        if (a[i].Contains("@"))
                        {
                            break;
                        }
                        artistName += a[i] + " ";

                        a[i] = string.Empty;
                    }

                    for (int i = 0; i < a.Length - 1; i++)
                    {
                        try
                        {
                            ticketPrice = long.Parse(a[i]);
                            ticketCount = long.Parse(a[i + 1]);
                        }
                        catch (FormatException)
                        {
                            venueName += a[i] + " ";
                        }
                    }

                    artistName = artistName.TrimEnd();
                    venueName = venueName.TrimStart(splitter).TrimEnd();

                    if (output.ContainsKey(venueName))
                    {
                        if (output[venueName].ContainsKey(artistName))
                        {
                            output[venueName][artistName] += (ticketCount * ticketPrice);
                        }
                        else
                        {
                            output[venueName].Add(artistName, (ticketPrice * ticketCount));
                        }
                    }
                    else
                    {
                        output.Add(venueName, new Dictionary<string, long>());
                        output[venueName].Add(artistName, (ticketCount * ticketPrice));
                    }
                    b = Console.ReadLine();
                }
                else
                {
                    b = Console.ReadLine();
                }
                if (b == "End") { break; }
            }


            foreach (var venue in output)
            {
                Console.WriteLine($"{venue.Key}");

                foreach (var name in venue.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {name.Key} -> {name.Value}");
                }
            }
        }
    }
}
