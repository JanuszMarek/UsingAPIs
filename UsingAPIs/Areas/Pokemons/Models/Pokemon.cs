using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAPIs.Areas.Pokemons.Models
{
    public class NameUrl
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class JustURL
    {
        public string url { get; set; }
    }

    public class Name
    {
        public NameUrl language { get; set; }
        public string name { get; set; }
    }

    public class FlavorTextEntry
    {
        public string flavor_text { get; set; }
        public NameUrl language { get; set; }
        public NameUrl version_group { get; set; }
    }

    public class Ability
    {
        public NameUrl ability { get; set; }
        public bool is_hidden { get; set; }
        public int slot { get; set; }
    }

    public class GameIndice
    {
        public int game_index { get; set; }
        public NameUrl version { get; set; }
    }

    public class VersionGroupDetail
    {
        public int level_learned_at { get; set; }
        public NameUrl move_learn_method { get; set; }
        public NameUrl version_group { get; set; }
    }

    public class Move
    {
        public NameUrl move { get; set; }
        public List<VersionGroupDetail> version_group_details { get; set; }
    }

    public class Sprites
    {
        public string back_default { get; set; }
        public string back_female { get; set; }
        public string back_shiny { get; set; }
        public string back_shiny_female { get; set; }
        public string front_default { get; set; }
        public string front_female { get; set; }
        public string front_shiny { get; set; }
        public string front_shiny_female { get; set; }
    }

    public class Stat
    {
        public int base_stat { get; set; }
        public int effort { get; set; }
        public NameUrl stat { get; set; }
    }

    public class Type
    {
        public int slot { get; set; }
        public NameUrl type { get; set; }
    }

    public class Pokemon
    {
        public List<Ability> abilities { get; set; }
        public int base_experience { get; set; }
        public List<NameUrl> forms { get; set; }
        public List<GameIndice> game_indices { get; set; }
        public int height { get; set; }
        public List<object> held_items { get; set; }
        public int id { get; set; }
        public bool is_default { get; set; }
        public string location_area_encounters { get; set; }
        public List<Move> moves { get; set; }
        public string name { get; set; }
        public int order { get; set; }
        public NameUrl species { get; set; }
        public Sprites sprites { get; set; }
        public List<Stat> stats { get; set; }
        public List<Type> types { get; set; }
        public int weight { get; set; }

        public static string ApiName => "pokemon";
    }
}
