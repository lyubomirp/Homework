using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyRoster
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Employee> list = new List<Employee>();
            Dictionary<string, decimal> deps = new Dictionary<string, decimal>();

            for (int i = 0; i < count; i++)
            {
                string[] employee = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (deps.ContainsKey(employee[3]))
                {
                    deps[employee[3]] += decimal.Parse(employee[1]);
                }
                else
                {
                    deps.Add(employee[3], decimal.Parse(employee[1]));
                }

                if (employee.Length > 5)
                {
                    list.Add(new Employee(employee[0], decimal.Parse(employee[1]), employee[2], employee[3], employee[4], int.Parse(employee[5])));
                } else if (employee.Length > 4)
                {
                    try
                    {
                        list.Add(new Employee(employee[0], decimal.Parse(employee[1]), employee[2], employee[3], int.Parse(employee[4])));
                    } catch (FormatException)
                    {
                        list.Add(new Employee(employee[0], decimal.Parse(employee[1]), employee[2], employee[3], employee[4]));

                    }
                } else
                {
                    list.Add(new Employee(employee[0], decimal.Parse(employee[1]), employee[2], employee[3]));
                }
            }

            Console.WriteLine($"Highest Average Salary: {deps.OrderByDescending(x=>x.Value).First().Key}");

            foreach (var person in list.OrderByDescending(x=>x.Salary))
            {
                if(person.Department == deps.OrderByDescending(x => x.Value).First().Key)
                {
                    Console.WriteLine($"{person.Name} {person.Salary:F2} {person.Email} {person.Age}");
                }
            }
        }
    }
}
