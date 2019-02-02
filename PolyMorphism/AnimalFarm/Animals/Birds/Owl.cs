using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarm.Animals
{
    class Owl : Bird, ISoundProducable
    {
        public Owl(string name, double weight, int foodEaten, double wingSize) : base(name, weight, foodEaten, wingSize)
        {
        }

        public void ProduceSound()
        {
            Console.WriteLine("Hoot Hoot");
        }

        public override void EatFood(int foodQuantity)
        {
            Weight += foodQuantity * 0.25;
        }
    }
}
