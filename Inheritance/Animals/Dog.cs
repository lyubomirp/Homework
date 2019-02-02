using Animals.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    class Dog:Animal
    {
        
        public Dog(string name, int age, string gender):base(name, age, gender)
        {
        }

        public void Sound()
        {
            Console.WriteLine("Woof!");
        }
    }
}
