using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaCalories
{
    class Dough
    {
        private string[] doughTypes = {"white","wholegrain"};
        private string[] bakingTechniques = { "crispy", "chewy", "homemade" };

        public Dough()
        {

        }


        private string flourType;
        private string bakingTechnique;
        private double weight;
        private double caloriesPerGram;

        public double CaloriesPerGram
        {
            get
            {
                return caloriesPerGram;
            }
            private set
            {
                caloriesPerGram = value;
            }
        }

        private double CalculateCalories(double weight, string flourType, string bakingTechnique)
        {
            double flourModifier = 0;
            double bakingModifier = 0;

            switch (flourType.ToLower())
            {
                case "white":
                    flourModifier = 1.5;
                    break;
                case "wholegrain":
                    flourModifier = 1.0;
                    break;
            }

            switch (bakingTechnique.ToLower())
            {
                case "crispy":
                    bakingModifier = 0.9;
                    break;
                case "chewy":
                    bakingModifier = 1.1;
                    break;
                case "homemade":
                    bakingModifier = 1.0;
                    break;
            }

            return (2 * weight) * (flourModifier * bakingModifier);


        }

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
            this.CaloriesPerGram = CalculateCalories(weight, flourType, bakingTechnique);
        }

        private string FlourType
        {
            get { return flourType; }
            set
            {
                if(!doughTypes.Contains(value.ToLower()))
                {
                    InvalidDough("Invalid type of dough.");
                }
                flourType = value;
            }
        }

        private string BakingTechnique
        {
            get { return bakingTechnique; }
            set
            {
                if (!bakingTechniques.Contains(value.ToLower()))
                {
                    InvalidDough("Invalid type of dough.");
                }
                bakingTechnique = value;
            }
        }

        private double Weight
        {
            get { return weight; }
            set
            {
                if(value < 1 || value > 200)
                {
                    InvalidDough("Dough weight should be in the range [1..200].");
                }
                weight = value;
            }
        }


        private void InvalidDough(string v)
        {
            throw new ArgumentException(v);
        }
    }
}
