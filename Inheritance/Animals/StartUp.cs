using Animals.Exceptions;
using System;
using System.Collections.Generic;

namespace Animals
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            List<Animal> animals = new List<Animal>();

            while (type != "Beast!")
            {
                string[] details = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name;
                int age;
                string gender;

                try
                {
                    switch (type)
                    {
                        case "Cat":
                            name = details[0];
                            if (!int.TryParse(details[1], out age))
                            {
                                throw new InvalidInput();
                            }
                            gender = details[2];
                            Cat cat = new Cat(name, age, gender);
                            animals.Add(cat);
                            break;
                        case "Dog":
                            name = details[0];
                            if (!int.TryParse(details[1], out age))
                            {
                                throw new InvalidInput();
                            }
                            gender = details[2];
                            Dog dog = new Dog(name, age, gender);
                            animals.Add(dog);
                            break;
                        case "Frog":
                            name = details[0];
                            if (!int.TryParse(details[1], out age))
                            {
                                throw new InvalidInput();
                            }
                            gender = details[2];
                            Frog frog = new Frog(name, age, gender);
                            animals.Add(frog);
                            break;
                        case "Tomcat":
                            name = details[0];
                            if (!int.TryParse(details[1], out age))
                            {
                                throw new InvalidInput();
                            }
                            Tomcat tomcat = new Tomcat(name, age);
                            animals.Add(tomcat);
                            break;
                        case "Kitten":
                            name = details[0];
                            if (!int.TryParse(details[1], out age))
                            {
                                throw new InvalidInput();
                            }
                            Kitten kitten = new Kitten(name, age);
                            animals.Add(kitten);
                            break;
                        default:
                            throw new InvalidInput();
                    }
                }catch(InvalidInput e)
                {
                    Console.WriteLine(e.Message);
                }

                type = Console.ReadLine();
            }

            foreach (var animal in animals)
            {
                Console.Write(animal.ToString());
                animal.GetType().GetMethod("Sound").Invoke(animal, null);

            }
        }
    }
}
