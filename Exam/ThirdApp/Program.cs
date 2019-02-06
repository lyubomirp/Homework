using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double totalIncome = 0.0;
            string name = string.Empty;
            string product = string.Empty;
            int count = 0;
            double price = 0.0;

            string pattern = @"(\%[A-Z][a-z]+\%)(([^\|\%\$\.])*)(\<\w+\>)(([^\|\%\$\.])*)(\|\d+\|)([^\|\%\$\.]*(\d+(\.?)\d+))\$";

            List<string> customers = new List<string>();

            while (input!="end of shift")
            {
                
                if(Regex.IsMatch(input, pattern))
                {
                    Match a = Regex.Match(input, pattern);

                    name = a.Groups[1].Value.Trim(new char[] { '%', '<', '>', '|', '$' });
                    product = a.Groups[4].Value.Trim(new char[] { '%', '<', '>', '|', '$' });
                    count = int.Parse(a.Groups[7].Value.Trim(new char[] { '%', '<', '>', '|', '$' }));
                    try
                    {
                        price = double.Parse(a.Groups[8].Value.Trim(new char[] { '%', '<', '>', '|', '$' }));
                    }
                    catch (FormatException)
                    {
                        price = double.Parse(a.Groups[9].Value.Trim(new char[] { '%', '<', '>', '|', '$' }));
                    }

                    totalIncome += price*count;

                    customers.Add($"{name}: {product} - {(price * count):F2}");
                }

                input = Console.ReadLine();

            }

            foreach(var customer in customers)
            {
                Console.WriteLine(customer);
            }
            Console.WriteLine($"Total income: {totalIncome:F2}");
        }
    }
}
