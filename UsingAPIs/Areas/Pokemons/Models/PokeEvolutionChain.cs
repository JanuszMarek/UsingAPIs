﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAPIs.Areas.Pokemons.Models
{
    public class EvolutionDetail
    {
        public int? gender { get; set; }
        public NameUrl held_item { get; set; }
        public NameUrl item { get; set; }
        public NameUrl known_move { get; set; }
        public NameUrl known_move_type { get; set; }
        public NameUrl location { get; set; }
        public object min_affection { get; set; }
        public object min_beauty { get; set; }
        public object min_happiness { get; set; }
        public object min_level { get; set; }
        public bool needs_overworld_rain { get; set; }
        public NameUrl party_species { get; set; }
        public NameUrl party_type { get; set; }
        public int? relative_physical_stats { get; set; }
        public string time_of_day { get; set; }
        public NameUrl trade_species { get; set; }
        public NameUrl trigger { get; set; }
        public bool turn_upside_down { get; set; }
    }

    public class EvolvesTo
    {
        public List<EvolutionDetail> evolution_details { get; set; }
        public List<EvolvesTo> evolves_to { get; set; }
        public bool is_baby { get; set; }
        public NameUrl species { get; set; }
        public Pokemon Pokemon { get; set; }
    }

    public class Chain
    {
        public List<EvolutionDetail> evolution_details { get; set; }
        public List<EvolvesTo> evolves_to { get; set; }
        public bool is_baby { get; set; }
        public NameUrl species { get; set; }
        public Pokemon FirstPokemon { get; set; }
    }

    public class PokeEvolutionChain
    {
        public object baby_trigger_item { get; set; }
        public Chain chain { get; set; }
        public int id { get; set; }
    }
}
