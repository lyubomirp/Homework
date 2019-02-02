using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree.Models
{
    class Product
    {
        string name;
        double cost;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public double Cost
        {
            get
            {
                return cost;
            }
            set
            {
                if (value < 0)
                {
                    InvalidInput("Money cannot be negative");
                }
                cost = value;
            }
        }

        private void InvalidInput(string v)
        {
            throw new ArgumentException(v);
        }

        public Product(string name, double cost)
        {
            this.Name = name;
            this.Cost = cost;
        }
    }
}
