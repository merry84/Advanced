using PokemonTrainer;

namespace _09.PokemonTrainer
{
    public class Program
    {
        static void Main()
        {
            var trainers = new Dictionary<string, Trainer>();
            string input;
            while ((input = Console.ReadLine()) != "Tournament")
            {
                var trainerInfo = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var trainerName = trainerInfo[0];
                var pokemonName = trainerInfo[1];
                var pokemonElement = trainerInfo[2];
                var pokemonHealth = int.Parse(trainerInfo[3]);
                if (!trainers.ContainsKey(trainerName))
                {
                    trainers[trainerName] = new Trainer(trainerName);
                }
                
                trainers[trainerName].CollectionOfPokemon.Add(new Pokemon(pokemonName, pokemonElement, pokemonHealth));
            }

            string input2;
            while ((input2 = Console.ReadLine()) != "End")
            {
                var element = input2;
                foreach (var trainer in trainers.Values)
                {
                    if (trainer.CollectionOfPokemon.Any(pokemon => pokemon.Element == element))
                    {
                        trainer.NumberOfBadges++;
                    }
                    else
                    {
                        foreach (var pokemon in trainer.CollectionOfPokemon)
                        {
                            pokemon.Health -= 10;
                        }
                        trainer.CollectionOfPokemon.RemoveAll(pokemon => pokemon.Health <= 0);
                    }
                }
            }
            foreach (var trainer in trainers.OrderByDescending(trainer => trainer.Value.NumberOfBadges))
            {
                Console.WriteLine(trainer.Value);
            }
        }
    }
}