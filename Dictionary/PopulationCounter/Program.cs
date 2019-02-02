using System;
using System.Collections.Generic;
using System.Linq;

namespace PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split('|');

            PopCounter(input);
        }

        static void PopCounter(string[] a)
        {

            Dictionary<string, Dictionary<string, long>> statistics = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, long> countrySort = new Dictionary<string, long>();
            long sum = 0;
            while (a[0] != "report")
            {
                string city = a[0];
                long pop = long.Parse(a[2]);
                string country = a[1];


                if (!(statistics.ContainsKey(country)))
                {
                    statistics.Add(country, new Dictionary<string, long>());
                    statistics[country].Add(city, pop);
                    sum += pop;
                }
                else
                {
                    if (!(statistics[country].ContainsKey(city)))
                    {
                        statistics[country].Add(city, pop);
                        sum += pop;
                    }
                    else
                    {
                        statistics[country][city] += pop;
                        sum += pop;
                    }
                }

                if (!(countrySort.ContainsKey(country)))
                {
                    countrySort.Add(country, sum);
                }
                else
                {
                    countrySort[country] += sum;
                }

                sum = 0;

                a = Console.ReadLine()
                .Split('|');
            }


            foreach(var order in countrySort.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{order.Key} (total population: {order.Value})");
                foreach(var c in statistics)
                {
                    foreach(var city in c.Value.OrderByDescending(x=>x.Value))
                    {
                        if (c.Key.Equals(order.Key))
                        {
                            Console.WriteLine($"=>{city.Key}: {city.Value}");
                        }
                    }
                }
            }
            
        }
    }
}
