using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAPIs.Areas.Pokemons.Models
{
    public class EffectEntry
    {
        public string effect { get; set; }
        public NameUrl language { get; set; }
        public string short_effect { get; set; }
    }

    public class Machine
    {
        public JustURL machine { get; set; }
        public NameUrl version_group { get; set; }
    }

    public class Meta
    {
        public NameUrl ailment { get; set; }
        public int ailment_chance { get; set; }
        public NameUrl category { get; set; }
        public int crit_rate { get; set; }
        public int drain { get; set; }
        public int flinch_chance { get; set; }
        public int healing { get; set; }
        public object max_hits { get; set; }
        public object max_turns { get; set; }
        public object min_hits { get; set; }
        public object min_turns { get; set; }
        public int stat_chance { get; set; }
    }

    public class PastValue
    {
        public int? accuracy { get; set; }
        public object effect_chance { get; set; }
        public List<object> effect_entries { get; set; }
        public object power { get; set; }
        public object pp { get; set; }
        public object type { get; set; }
        public NameUrl version_group { get; set; }
    }

    public class PokeMove
    {
        public int? accuracy { get; set; }
        public object contest_combos { get; set; }
        public JustURL contest_effect { get; set; }
        public NameUrl contest_type { get; set; }
        public NameUrl damage_class { get; set; }
        public object effect_chance { get; set; }
        public List<object> effect_changes { get; set; }
        public List<EffectEntry> effect_entries { get; set; }
        public List<FlavorTextEntry> flavor_text_entries { get; set; }
        public NameUrl generation { get; set; }
        public int id { get; set; }
        public List<Machine> machines { get; set; }
        public Meta meta { get; set; }
        public string name { get; set; }
        public List<Name> names { get; set; }
        public List<PastValue> past_values { get; set; }
        public int? power { get; set; }
        public int pp { get; set; }
        public int priority { get; set; }
        public List<object> stat_changes { get; set; }
        public JustURL super_contest_effect { get; set; }
        public NameUrl target { get; set; }
        public NameUrl type { get; set; }
    }
}
