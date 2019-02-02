using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarm.Animals
{
    class Mammal : Animal
    {
        private string livingRegion;

        public string LivingRegion
        {
            get { return livingRegion; }
            set { livingRegion = value; }
        }


        public Mammal(string name, double weight, int foodEaten, string livingRegion) : base(name, weight, foodEaten)
        {
            this.livingRegion = livingRegion;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{Name}, {Weight}, {livingRegion}, {FoodEaten}]";
        }
    }
}
