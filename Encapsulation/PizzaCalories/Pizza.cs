using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaCalories
{
    class Pizza
    {
        Dough dough;
        string name;
        List<Toppings> toppings;
        double calories;

        public Pizza(string name, Dough dough, List<Toppings> toppings)
        {
            this.Name = name;
            this.Toppings = toppings;
            this.Dough = dough;
            this.Calories = TotalCalories(dough, toppings);
        }

        public Dough Dough
        {
            get
            {
                return dough;
            }
            set
            {
                dough = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length > 15 
                    || value.Length <= 1 || value.ToLower() == "null")
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
               this.name = value;
            }
        }

        public double Calories
        {
            get
            {
                return calories;
            }
            set
            {
                calories = value;
            }
        }

        public List<Toppings> Toppings
        {
            get
            {
                return toppings;
            }
           private set
            {
                if (value.Count >= 10)
                {
                    throw new ArgumentException("Number of toppings should be in range [0..10].");
                }
                toppings = value;
            }
        }

        public double TotalCalories(Dough dough, List<Toppings> toppings)
        {
            double fullCalories = this.Dough.CaloriesPerGram + this.Toppings.Sum(x=>x.Calories);

            return fullCalories;
        }

        public void AddDough(Dough dough)
        {
            this.dough = dough;
        }

        public void AddTopping(Toppings toppings)
        {
            this.toppings.Add(toppings);
            if (this.toppings.Count > 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
        }
    }
}
