using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAPIs.Areas.Pokemons.Models.PokemonMove
{
    public class ContestEffect
    {
        public string url { get; set; }
    }

    public class ContestType
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class DamageClass
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Language
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class EffectEntry
    {
        public string effect { get; set; }
        public Language language { get; set; }
        public string short_effect { get; set; }
    }

    public class Language2
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class VersionGroup
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class FlavorTextEntry
    {
        public string flavor_text { get; set; }
        public Language2 language { get; set; }
        public VersionGroup version_group { get; set; }
    }

    public class Generation
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Machine2
    {
        public string url { get; set; }
    }

    public class VersionGroup2
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Machine
    {
        public Machine2 machine { get; set; }
        public VersionGroup2 version_group { get; set; }
    }

    public class Ailment
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Category
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Meta
    {
        public Ailment ailment { get; set; }
        public int ailment_chance { get; set; }
        public Category category { get; set; }
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

    public class Language3
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Name
    {
        public Language3 language { get; set; }
        public string name { get; set; }
    }

    public class VersionGroup3
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class PastValue
    {
        public int accuracy { get; set; }
        public object effect_chance { get; set; }
        public List<object> effect_entries { get; set; }
        public object power { get; set; }
        public object pp { get; set; }
        public object type { get; set; }
        public VersionGroup3 version_group { get; set; }
    }

    public class SuperContestEffect
    {
        public string url { get; set; }
    }

    public class Target
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Type
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class PokeMove
    {
        public int accuracy { get; set; }
        public object contest_combos { get; set; }
        public ContestEffect contest_effect { get; set; }
        public ContestType contest_type { get; set; }
        public DamageClass damage_class { get; set; }
        public object effect_chance { get; set; }
        public List<object> effect_changes { get; set; }
        public List<EffectEntry> effect_entries { get; set; }
        public List<FlavorTextEntry> flavor_text_entries { get; set; }
        public Generation generation { get; set; }
        public int id { get; set; }
        public List<Machine> machines { get; set; }
        public Meta meta { get; set; }
        public string name { get; set; }
        public List<Name> names { get; set; }
        public List<PastValue> past_values { get; set; }
        public int power { get; set; }
        public int pp { get; set; }
        public int priority { get; set; }
        public List<object> stat_changes { get; set; }
        public SuperContestEffect super_contest_effect { get; set; }
        public Target target { get; set; }
        public Type type { get; set; }
    }
}
