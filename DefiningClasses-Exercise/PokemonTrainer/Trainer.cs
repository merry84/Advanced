using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainer
{
    public class Trainer
    {
        //•	Name
        // •	Number of badges
        // •	A collection of pokemon
        private string name;
        private int numberOfBadges;
        private List<Pokemon> collectionOfPokemon;
        public string Name { get; set; }
        public int  NumberOfBadges { get; set; }
        public List<Pokemon> CollectionOfPokemon { get; set; }

        public Trainer(string name)
        {
            Name = name;
            NumberOfBadges = 0;
            CollectionOfPokemon = new List<Pokemon>();
        }

        public override string ToString()
        {
            return ($"{Name} {NumberOfBadges} {CollectionOfPokemon.Count}");
        } 


    }
}
