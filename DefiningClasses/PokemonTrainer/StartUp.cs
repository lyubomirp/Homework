using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Dictionary<Trainer, List<Pokemon>> trainers = new Dictionary<Trainer, List<Pokemon>>();
            List<Pokemon> pokemon = new List<Pokemon>();

            while (input[0] != "Tournament")
            {
                string trainerName = input[0];
                string pokemonName = input[1];
                string pokemonType = input[2];
                int pokemonHealth = int.Parse(input[3]);

                Pokemon currentPoke = new Pokemon(pokemonName, pokemonType, pokemonHealth);
                pokemon.Add(currentPoke);

                if (trainers.Keys.Any(x => x.Name == trainerName))
                {
                    trainers[trainers.Keys.First(x => x.Name == trainerName)].Add(currentPoke);
                } else
                {
                    Trainer trainer = new Trainer(trainerName);

                    trainers.Add(trainer, new List<Pokemon>());
                    trainers[trainer].Add(currentPoke);
                }

                input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            }

            string element = Console.ReadLine();

            while (element != "End")
            {
                foreach(var guy in trainers)
                {
                    if(guy.Value.Any(x=>x.Element == element))
                    {
                        guy.Key.Badges++;
                    } else
                    {
                        foreach (var pokemone in guy.Value)
                        {
                            pokemone.Health = pokemone.Health - 10;
                        }

                        guy.Value.RemoveAll(x => x.Health <= 0);
                    }
                }

                element = Console.ReadLine();
            }

            foreach (var person in trainers.OrderByDescending(x=>x.Key.Badges))
            {
                Console.WriteLine($"{person.Key.Name} {person.Key.Badges} {person.Value.Count()}");
            }
        }
    }
}
