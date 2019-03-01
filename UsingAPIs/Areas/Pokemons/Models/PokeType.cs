using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAPIs.Areas.Pokemons.Models
{
    public class DoubleDamageFrom
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class HalfDamageTo
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class NoDamageFrom
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class NoDamageTo
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class DamageRelations
    {
        public List<DoubleDamageFrom> double_damage_from { get; set; }
        public List<object> double_damage_to { get; set; }
        public List<object> half_damage_from { get; set; }
        public List<HalfDamageTo> half_damage_to { get; set; }
        public List<NoDamageFrom> no_damage_from { get; set; }
        public List<NoDamageTo> no_damage_to { get; set; }
    }

    public class MoveDamageClass
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Language
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Name
    {
        public Language language { get; set; }
        public string name { get; set; }
    }

    public class PokeType
    {
        public DamageRelations damage_relations { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public List<Name> names { get; set; }
    }
}
