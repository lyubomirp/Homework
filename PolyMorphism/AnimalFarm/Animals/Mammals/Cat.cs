using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarm.Animals.Mammals
{
    class Cat : Feline, ISoundProducable
    {
        public Cat(string name, double weight, int foodEaten, string livingRegion, string breed) : base(name, weight, foodEaten, livingRegion, breed)
        {
        }

        public void ProduceSound()
        {
            Console.WriteLine("Meow");
        }

        public override void EatFood(int foodQuantity)
        {
            Weight += foodQuantity * 0.30;
        }
    }
}
