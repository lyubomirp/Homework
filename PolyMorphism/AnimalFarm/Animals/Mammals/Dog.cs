using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarm.Animals.Mammals
{
    class Dog : Mammal, ISoundProducable
    {
        public Dog(string name, double weight, int foodEaten, string livingRegion) : base(name, weight, foodEaten, livingRegion)
        {
        }

        public void ProduceSound()
        {
            Console.WriteLine("Woof!");
        }

        public override void EatFood(int foodQuantity)
        {
            Weight += foodQuantity * 0.40;
        }
    }
}
