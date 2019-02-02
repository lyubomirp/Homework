using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AndreiAndBilliard
{
    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> Order { get; set; }
        public double Bill { get; set; }


        public static void BillCalculator(List<Customer> people, Dictionary<string, double> shop)
        {
            var totalBill = 0.0;
            foreach(var guy in people)
            {
                foreach(var kvp in guy.Order)
                {
                    var price = shop.GetValueOrDefault(kvp.Key);

                    guy.Bill = price * kvp.Value;

                    totalBill += guy.Bill;
                }
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
