using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using UsingAPIs.Areas.Pokemons.Models;
using UsingAPIs.Controllers;

namespace UsingAPIs.Areas.Pokemons.Controllers
{
    [Area(nameof(Pokemons))]
    public class HomeController : ExtendedController
    {
        public IActionResult Index(int page = 1)
        {
            const int POKECOUNT = 807;
            const int PAGESIZE = 21;

            PokeListViewModel pokeListViewModel = new PokeListViewModel();
            pokeListViewModel.Pagination = new UsingAPIs.Models.PaginationClass();
            pokeListViewModel.Pagination.Limit = (int)Math.Ceiling((double)POKECOUNT / PAGESIZE);
            pokeListViewModel.Pagination.PageSize = (page * PAGESIZE) > POKECOUNT ? PAGESIZE - ((pokeListViewModel.Pagination.Limit * PAGESIZE) - POKECOUNT) : PAGESIZE;
            pokeListViewModel.Pagination.Page = page < pokeListViewModel.Pagination.Limit ? page : pokeListViewModel.Pagination.Limit;

            int offset = PAGESIZE * (pokeListViewModel.Pagination.Page - 1);

            string path = $"https://pokeapi.co/api/v2/pokemon/?offset={offset}&limit={pokeListViewModel.Pagination.PageSize}";
            PokeList pokeList = APIRequest(path).ToObject<PokeList>();

            pokeListViewModel.Pokemons = new List<Pokemon>();
            foreach(var item in pokeList.results)
            {
                pokeListViewModel.Pokemons.Add(APIRequest(item.url).ToObject<Pokemon>());
            }

            return View(pokeListViewModel);
        }

        
        public IActionResult Detail(string id = "1")
        {
            string path = $"https://pokeapi.co/api/v2/pokemon/{id}/";

            Pokemon pokemon = APIRequest(path).ToObject<Pokemon>();

            return View(pokemon);
        }
    }
}