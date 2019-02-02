using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarm.Animals.Mammals
{
    abstract class Feline : Mammal
    {
        private string breed;

        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }


        public Feline(string name, double weight, int foodEaten, string livingRegion, string breed) : base(name, weight, foodEaten, livingRegion)
        {
            this.breed = breed;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{Name}, {breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
