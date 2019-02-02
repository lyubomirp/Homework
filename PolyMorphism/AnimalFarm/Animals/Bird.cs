using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarm.Animals
{
    class Bird : Animal
    {
        private double wingSize;

        public double WingSize
        {
            get { return wingSize; }
            set { wingSize = value; }
        }


        public Bird(string name, double weight, int foodEaten, double wingSize) : base(name, weight, foodEaten)
        {
            this.wingSize = wingSize;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{Name}, {wingSize}, {Weight}, {FoodEaten}]";
        }
    }
}
