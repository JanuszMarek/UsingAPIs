using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsingAPIs.Areas.Pokemons.Models.PokemonMove;

namespace UsingAPIs.Areas.Pokemons.Models
{
    public interface IPokeRepository
    {
        int PokeCount { get; }
        Pokemon this[string name] { get; }

        PokeMove PokeMove(string name, string path);
    }
}
