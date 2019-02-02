using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarm.Animals.Mammals
{
    class Tiger : Feline, ISoundProducable
    {
        public Tiger(string name, double weight, int foodEaten, string livingRegion, string breed) : base(name, weight, foodEaten, livingRegion, breed)
        {
        }

        public override void EatFood(int foodQuantity)
        {
            Weight += foodQuantity * 1.00;
        }

        public void ProduceSound()
        {
            Console.WriteLine("ROAR!!!");
        }
    }
}
