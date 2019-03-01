using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAPIs.Areas.Pokemons.Models
{
    public interface IPokeRepository
    {
        IEnumerable<Pokemon> Pokemons { get; }
        Pokemon this[string id] { get; }
        int PokeCount { get; }
    }
}
