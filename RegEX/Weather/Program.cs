using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<City> result = new List<City>();

            while (input != "end")
            {
                string pattern = @"([A-Z]{2})((\d+)[.](\d+))(([a-zA-Z])[a-z]+)(?:\|)";

                string[] cityInfo = new string[3];


                if (Regex.IsMatch(input, pattern))
                {
                    cityInfo[0] = Regex.Match(input, pattern).Groups[1].ToString();
                    cityInfo[1] = Regex.Match(input, pattern).Groups[2].ToString();
                    cityInfo[2] = Regex.Match(input, pattern).Groups[5].ToString();

                    if (result.Any(x => x.Code == cityInfo[0]))
                    {
                        City currCity = result.Find(x => x.Code == cityInfo[0]);

                        currCity.Temperature = double.Parse(cityInfo[1]);
                        currCity.Weather = cityInfo[2];
                    }
                    else
                    {

                        City newCity = new City
                        {
                            Code = cityInfo[0],
                            Temperature = double.Parse(cityInfo[1]),
                            Weather = cityInfo[2]
                        };

                        result.Add(newCity);
                    }

                }
                input = Console.ReadLine();

            }

            foreach(var city in result.OrderBy(x=>x.Temperature))
            {
                Console.WriteLine($"{city.Code} => {city.Temperature:F2} => {city.Weather}");
            }
        }
    }



    class City
    {
        public string Code
        {
            get;
            set;
        }

        public double Temperature
        {
            get;
            set;
        }

        public string Weather
        {
            get;
            set;
        }
    }
}
