using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarm
{
    abstract class Animal
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private double weight;

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        private int foodEaten;

        public int FoodEaten
        {
            get { return foodEaten; }
            set { foodEaten = value; }
        }

        public Animal(string name, double weight, int foodEaten)
        {
            this.name = name;
            this.weight = weight;
            this.foodEaten = foodEaten;
        }

        public virtual void EatFood(int foodQuantity)
        {
            for (int i = 0; i < foodQuantity; i++)
            {
                weight++;
            }
        }

    }
}
