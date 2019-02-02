using AnimalFarm.Animals;
using AnimalFarm.Animals.Mammals;
using System;
using System.Collections.Generic;

namespace AnimalFarm
{
    class StartUp
    {
        static List<Animal> animals;

        static void Main(string[] args)
        {
            animals = new List<Animal>();
            string input = Console.ReadLine();
            int i = 0;

            while (input != "End")
            {
                string[] splitInput = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (i % 2 == 0)
                {
                    CreateAnimal(splitInput);
                }
                if (i % 2 != 0)
                {
                    FeedAnimal(i, animals, splitInput);
                }
                i++;
                input = Console.ReadLine();
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }

        private static void FeedAnimal(int i, List<Animal> animals, string[] splitInput)
        {
            string foodType = splitInput[0];
            int quantity = int.Parse(splitInput[1]);

            Animal animal = animals[animals.Count-1];

            switch (animal.GetType().Name.ToLower())
            {
                case "hen":
                    animal = animal as Hen;
                    animal.FoodEaten += quantity;
                    animal.EatFood(quantity);
                    break;
                case "owl":
                    animal = animal as Owl;
                    if (foodType.ToLower() != "meat")
                    {
                        Console.WriteLine($"{animal.GetType().Name} does not eat {foodType}!");
                        break;
                    }
                    animal.FoodEaten += quantity;
                    animal.EatFood(quantity);
                    break;
                case "mouse":
                    animal = animal as Mouse;
                    if (foodType.ToLower() != "vegetable" && foodType.ToLower()!="fruit")
                    {
                        Console.WriteLine($"{animal.GetType().Name} does not eat {foodType}!");
                        break;
                    }
                    animal.FoodEaten += quantity;
                    animal.EatFood(quantity);
                    break;
                case "cat":
                    animal = animal as Cat;
                    if (foodType.ToLower() != "vegetable" && foodType.ToLower() != "meat")
                    {
                        Console.WriteLine($"{animal.GetType().Name} does not eat {foodType}!");
                        break;
                    }
                    animal.FoodEaten += quantity;
                    animal.EatFood(quantity);
                    break;
                case "dog":
                    animal = animal as Dog;
                    if (foodType.ToLower() != "meat")
                    {
                        Console.WriteLine($"{animal.GetType().Name} does not eat {foodType}!");
                        break;
                    }
                    animal.FoodEaten += quantity;
                    animal.EatFood(quantity);
                    break;
                case "tiger":
                    animal = animal as Tiger;
                    if (foodType.ToLower() != "meat")
                    {
                        Console.WriteLine($"{animal.GetType().Name} does not eat {foodType}!");
                        break;
                    }
                    animal.FoodEaten += quantity;
                    animal.EatFood(quantity);
                    break;
            }
        }

        private static void CreateAnimal(string[] splitInput)
        {
            double wingSpan = 0;
            if (splitInput.Length > 4)
            {
                CreateCat(splitInput);
            } else if(double.TryParse(splitInput[3], out wingSpan))
            {
                CreateBird(splitInput);
            } else
            {
                CreateOther(splitInput);
            }
        }

        private static void CreateOther(string[] splitInput)
        {
            string name = splitInput[1];
            double weight = double.Parse(splitInput[2]);
            string livingArea = splitInput[3];

            switch (splitInput[0].ToLower())
            {
                case "dog":
                    Dog dog = new Dog(name, weight, 0, livingArea);
                    animals.Add(dog);
                    dog.ProduceSound();
                    break;
                case "mouse":
                    Mouse mouse = new Mouse(name, weight, 0, livingArea);
                    animals.Add(mouse);
                    mouse.ProduceSound();
                    break;
            }
        }

        private static void CreateBird(string[] splitInput)
        {
            string name = splitInput[1];
            double weight = double.Parse(splitInput[2]);
            double wingSize = double.Parse(splitInput[3]);

            switch (splitInput[0].ToLower())
            {
                case "hen":
                    Hen hen = new Hen(name, weight, 0, wingSize);
                    animals.Add(hen);
                    hen.ProduceSound();
                    break;
                case "owl":
                    Owl owl = new Owl(name, weight, 0, wingSize);
                    animals.Add(owl);
                    owl.ProduceSound();
                    break;
            }
        }

        private static void CreateCat(string[] splitInput)
        {
            string name = splitInput[1];
            double weight = double.Parse(splitInput[2]);
            string livingRegion = splitInput[3];
            string breed = splitInput[4];

            switch (splitInput[0].ToLower())
            {
                case "cat":
                    Cat cat = new Cat(name, weight, 0, livingRegion, breed);
                    animals.Add(cat);
                    cat.ProduceSound();
                    break;
                case "tiger":
                    Tiger tiger = new Tiger(name, weight, 0, livingRegion, breed);
                    animals.Add(tiger);
                    tiger.ProduceSound();
                    break;
            }
        }
    }
}
