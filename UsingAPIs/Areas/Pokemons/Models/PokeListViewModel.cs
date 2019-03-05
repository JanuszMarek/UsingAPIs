using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsingAPIs.Models;

namespace UsingAPIs.Areas.Pokemons.Models
{
    public class PokeListViewModel
    {
        public List<Pokemon> Pokemons { get; set; }

        public PaginationClass Pagination { get; set; }

        public int Offset { get; set; }
        public int LimitCount { get; set; }
        public int Generation { get; set; }


    }
}
