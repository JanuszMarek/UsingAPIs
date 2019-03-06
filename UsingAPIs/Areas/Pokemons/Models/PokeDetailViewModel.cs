using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsingAPIs.Areas.Pokemons.Models.PokemonEvolution;
using UsingAPIs.Areas.Pokemons.Models.PokemonMove;
using UsingAPIs.Areas.Pokemons.Models.PokemonSpecies;

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
