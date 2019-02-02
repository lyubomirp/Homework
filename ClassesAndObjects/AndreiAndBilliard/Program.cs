using System;
using System.Collections.Generic;
using System.Linq;

namespace AndreiAndBilliard
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, double> shop = ParseUserInput(n);
            var people = Patrons(shop);

            Customer.BillCalculator(people, shop);

        }

        static Dictionary<string, double> ParseUserInput(int n)
        {
            Dictionary<string, double> priceList = new Dictionary<string, double>();

            for (int i = 0; i < n; i++)
            {
                char[] denum = { '-', ',', ' ' };

                string[] input = Console.ReadLine()
                    .Split(denum, StringSplitOptions.RemoveEmptyEntries);

                if (priceList.ContainsKey(input[0]))
                {
                    priceList[input[0]] = double.Parse(input[1]);
                } else
                {
                    priceList.Add(input[0], double.Parse(input[1]));
                }
            }

            return priceList;

        }

        static List<Customer> Patrons(Dictionary<string, double> shop)
        {
            char[] denum = { '-', ',' };

            string[] customers = Console.ReadLine()
                .Split(denum, StringSplitOptions.RemoveEmptyEntries);

            List<Customer> people = new List<Customer>();

            while (customers[0]!= "end of clients")
            {
                if (shop.ContainsKey(customers[1]))
                {

                    var anotherOne = new Customer
                    {
                        Name = customers[0],
                        Order = new Dictionary<string, int>()
                    };
                    anotherOne.Order.Add(customers[1], int.Parse(customers[2]));

                    var comparer = people.FirstOrDefault(x => x.Name == anotherOne.Name);

                    if (comparer == null)
                    {
                        
                        people.Add(anotherOne);

                    } else
                    {
                        int index = 0;

                        index = people.IndexOf(people.Find(x => x.Name == anotherOne.Name));

                        foreach (var item in anotherOne.Order)
                        {
                            if (!people[index].Order.ContainsKey(item.Key))
                            {
                                people[index].Order.Add(item.Key, item.Value);
                            } else
                            {
                                people[index].Order[item.Key] += item.Value;
                            }
                        }
                    }

                }

                customers = Console.ReadLine()
                .Split(denum, StringSplitOptions.RemoveEmptyEntries);

                if (customers[0] == "end of clients") {
                    break;
                }
            }

            return people;
        }

        class Customer
        {
            public string Name { get; set; }
            public Dictionary<string, int> Order { get; set; }
            public double Bill { get; set; }


            public static void BillCalculator(List<Customer> people, Dictionary<string, double> shop)
            {
                var totalBill = 0.0;
                foreach (var guy in people)
                {
                    foreach (var kvp in guy.Order)
                    {
                        var price = 0.0;
                        shop.TryGetValue(kvp.Key, out price);

                        guy.Bill += price * kvp.Value;

                    }
                    totalBill += guy.Bill;
                }


                foreach (var person in people.OrderBy(x => x.Name))
                {
                    Console.WriteLine(person.Name);

                    foreach (var item in person.Order)
                    {
                        Console.WriteLine($"-- {item.Key} - {item.Value}");
                    }

                    Console.WriteLine($"Bill: {person.Bill:F2}");
                }

                Console.WriteLine($"Total bill: {totalBill:F2}");
            }
        }
    }
}
