using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsingAPIs.Areas.Pokemons.Models.PokemonMove;

namespace UsingAPIs.Areas.Pokemons.Models
{
    public class PokeDetailViewModel
    {
        public Pokemon Pokemon { get; set; }
        public List<PokeMove> PokeMoves { get; set; }
    }
}
