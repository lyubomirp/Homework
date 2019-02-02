using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaCalories
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Dough dough = new Dough();
            string pizzaName = "default";
            Pizza pizza = new Pizza(pizzaName, dough, new List<Toppings>());

            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (input[0].ToLower() == "pizza" && input.Length >= 3)
            {
                for (int i = 2; i < input.Length; i++)
                {
                    input[1] += " " + input[i];
                }
            }

            try
            {
                while (input[0] != "END")
                {

                    switch (input[0].ToLower())
                    {

                        case "dough":
                            dough = new Dough(input[1], input[2], double.Parse(input[3]));
                            pizza.AddDough(dough);
                            break;
                        case "topping":
                            Toppings topping = new Toppings(input[1], double.Parse(input[2]));
                            pizza.AddTopping(topping);
                            break;
                        case "pizza":
                            try
                            {
                                pizzaName = input[1];
                                pizza.Name = pizzaName;
                            }
                            catch (IndexOutOfRangeException)
                            {
                                pizzaName = " ";
                            }
                            break;
                    }
                    input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                }
                if(pizza.Name == "default")
                {
                    Console.WriteLine("Pizza name should be between 1 and 15 symbols.");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine($"{pizza.Name} - {pizza.TotalCalories(pizza.Dough, pizza.Toppings):F2} Calories.");

                }
            }
            catch (ArgumentException err)
            {
                Console.WriteLine(err.Message);
            }

        }


    }
}
