using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree.Models
{
    class Person
    {
        private double money;
        private string name;
        List<Product> products = new List<Product>();

        public Person(string name, double money, List<Product> products)
        {
            this.Money = money;
            this.Name = name;
            this.Products = products;
        }

        public double Money
        {
            get
            {
                return money;
            }
            set
            {
                if (value < 0)
                {
                    InvalidInput("Money cannot be negative");
                }
                money = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    InvalidInput("Name cannot be empty");
                }
                name = value;
            }
        }

        public List<Product> Products
        {
            get
            {
                return products;
            }
            set
            {
                products = value;
            }
        }

        private void InvalidInput(string v)
        {
            throw new ArgumentException(v);
        }
    }
}
