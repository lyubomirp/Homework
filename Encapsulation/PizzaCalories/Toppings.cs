using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaCalories
{
    class Toppings
    {
        string[] toppingTypes = { "meat", "veggies", "cheese", "sauce" };

        private string topping;
        private double weight;
        private double calories;

        public double Calories
        {
            get
            {
                return calories;
            }
            private set
            {
                calories = value;
            }
        }

        string Topping
        {
            get
            {
                return topping;
            }
            set
            {
                if (!toppingTypes.Contains(value.ToLower()))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                topping = value;
            }
        }

        double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if(value<1 || value > 50)
                {
                    throw new ArgumentException($"{topping} weight should be in the range [1..50].");
                }
                weight = value;
            }
        }

        public Toppings(string topping, double weight)
        {
            this.Topping = topping;
            this.Weight = weight;
            this.Calories = CalculateCalories(topping, weight);
        }

        private double CalculateCalories(string topping, double weight)
        {
            double toppingModifier = 0;

            switch (topping.ToLower())
            {
                case "meat":
                    toppingModifier = 1.2;
                    break;
                case "veggies":
                    toppingModifier = 0.8;
                    break;
                case "cheese":
                    toppingModifier = 1.1;
                    break;
                case "sauce":
                    toppingModifier = 0.9;
                    break;             
            }

            return (2*weight)*toppingModifier;
        }
    }
}
