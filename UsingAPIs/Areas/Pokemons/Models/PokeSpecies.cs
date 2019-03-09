using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAPIs.Areas.Pokemons.Models
{
    public class Genera
    {
        public string genus { get; set; }
        public NameUrl language { get; set; }
    }

    public class PalParkEncounter
    {
        public NameUrl area { get; set; }
        public int base_score { get; set; }
        public int rate { get; set; }
    }

    public class PokedexNumber
    {
        public int entry_number { get; set; }
        public NameUrl pokedex { get; set; }
    }

    public class Variety
    {
        public bool is_default { get; set; }
        public NameUrl pokemon { get; set; }
    }

    public class PokeSpecies
    {
        public int base_happiness { get; set; }
        public int capture_rate { get; set; }
        public NameUrl color { get; set; }
        public List<NameUrl> egg_groups { get; set; }
        public JustURL evolution_chain { get; set; }
        public object evolves_from_species { get; set; }
        public List<FlavorTextEntry> flavor_text_entries { get; set; }
        public List<object> form_descriptions { get; set; }
        public bool forms_switchable { get; set; }
        public int gender_rate { get; set; }
        public List<Genera> genera { get; set; }
        public NameUrl generation { get; set; }
        public NameUrl growth_rate { get; set; }
        public NameUrl habitat { get; set; }
        public bool has_gender_differences { get; set; }
        public int hatch_counter { get; set; }
        public int id { get; set; }
        public bool is_baby { get; set; }
        public string name { get; set; }
        public List<Name> names { get; set; }
        public int order { get; set; }
        public List<PalParkEncounter> pal_park_encounters { get; set; }
        public List<PokedexNumber> pokedex_numbers { get; set; }
        public NameUrl shape { get; set; }
        public List<Variety> varieties { get; set; }
    }
}
