using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AnimalFarm.Animals.Mammals
{
    class Mouse : Mammal,ISoundProducable
    {
        public Mouse(string name, double weight, int foodEaten, string livingRegion) : base(name, weight, foodEaten, livingRegion)
        {
        }

        public void ProduceSound()
        {
            Console.WriteLine("Squeak");
        }

        public override void EatFood(int foodQuantity)
        {
            Weight += foodQuantity * 0.10;
        }
    }
}
