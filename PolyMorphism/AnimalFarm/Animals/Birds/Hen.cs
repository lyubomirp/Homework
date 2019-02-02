using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarm.Animals
{
    class Hen : Bird, ISoundProducable
    {
        public Hen(string name, double weight, int foodEaten, double wingSize) : base(name, weight, foodEaten, wingSize)
        {
        }

        public void ProduceSound()
        {
            Console.WriteLine("Cluck");
        }

        public override void EatFood(int foodQuantity)
        {
            Weight += foodQuantity * 0.35;
        }
    }
}
