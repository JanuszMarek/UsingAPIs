using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace UsingAPIs.Areas.Pokemons.Models
{
    public class PokeDetailViewModel
    {
        public Pokemon Pokemon { get; set; }
        public PokeSpecies PokeSpecies { get; set; } 
        public List<PokeMove> PokeMoves { get; set; }
        public PokeEvolutionChain EvolutionChain { get; set; }
    }
}
