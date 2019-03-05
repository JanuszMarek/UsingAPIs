using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAPIs.Areas.Pokemons.Models
{
    public interface IPokeRepository
    {
        
        Pokemon this[string name] { get; }
        int PokeCount { get; }
    }
}
