﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace UsingAPIs.Areas.Pokemons.Models
{
    public interface IPokeRepository
    {
        int PokeCount { get; }
        Pokemon this[string name] { get; }

        PokeMove PokeMove(string name, string path);
        PokeSpecies PokeSpecies(string name, string path);
        PokeEvolutionChain EvolutionChain(string path);
    }
}
