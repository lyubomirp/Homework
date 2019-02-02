using ShoppingSpree.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    class Program
    {
        static List<Person> people;
        static List<Product> products;

        static void Main(string[] args)
        {
            people = new List<Person>();
            products = new List<Product>();

            string[] guys = Console.ReadLine()
                .Split(new char[] {'=', ';' }, StringSplitOptions.RemoveEmptyEntries);

            string[] stuff = Console.ReadLine()
                .Split(new char[] {'=', ';' }, StringSplitOptions.RemoveEmptyEntries);

            AddPeople(people, guys);
            AddProducts(stuff, products);

            string[] transaction = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            while (transaction[0] != "END")
            {
                string person = transaction[0];
                string product = transaction[1];

                Person guy = people.Find(x => x.Name == person);
                Product thing = products.Find(x => x.Name == product);

                if(guy.Money>= thing.Cost)
                {
                    guy.Products.Add(thing);
                    guy.Money -= thing.Cost;
                    Console.WriteLine($"{guy.Name} bought {thing.Name}");
                } else
                {
                    Console.WriteLine($"{guy.Name} can't afford {thing.Name}");
                }

                transaction = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var guy in people)
            {
                if (guy.Products.Count <= 0)
                {
                    Console.WriteLine($"{guy.Name} - Nothing bought");
                } else
                {
                    Console.WriteLine($"{guy.Name} - {string.Join(", ", guy.Products.Select(x=>x.Name))}");
                }
            }
        }

        private static void AddProducts(string[] stuff, List<Product> products)
        {
            for (int i = 0; i < stuff.Length - 1; i+=2)
            {
                try
                {
                    Product product = new Product(stuff[i], double.Parse(stuff[i+1]));
                    products.Add(product);
                }
                catch (ArgumentException exception)
                {
                    Console.WriteLine(exception.Message);
                    Environment.Exit(1);
                }

            }
        }

        private static void AddPeople(List<Person> people, string[] guys)
        {
            for (int i = 0; i < guys.Length-1; i+=2)
            {
                try
                {
                    Person person = new Person(guys[i], double.Parse(guys[i+1]), new List<Product>());
                    people.Add(person);
                }
                catch (ArgumentException exception)
                {
                    Console.WriteLine(exception.Message);
                    Environment.Exit(1);
                }
                
            }
        }
    }
}
