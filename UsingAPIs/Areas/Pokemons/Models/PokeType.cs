using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAPIs.Areas.Pokemons.Models
{
    public class DamageRelations
    {
        public List<NameUrl> double_damage_from { get; set; }
        public List<NameUrl> double_damage_to { get; set; }
        public List<NameUrl> half_damage_from { get; set; }
        public List<NameUrl> half_damage_to { get; set; }
        public List<NameUrl> no_damage_from { get; set; }
        public List<NameUrl> no_damage_to { get; set; }
    }

    public class PokeType
    {
        public DamageRelations damage_relations { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public List<Name> names { get; set; }
    }
}
