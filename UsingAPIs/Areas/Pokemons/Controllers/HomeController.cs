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
        private IPokeRepository repository;

        public HomeController(IPokeRepository pokeRepository)
        {
            repository = pokeRepository;
        }

        
        public IActionResult Index(int page = 1)
        {
            const int PAGESIZE = 21;

            PokeListViewModel pokeListViewModel = new PokeListViewModel();
            pokeListViewModel.Pagination = new UsingAPIs.Models.PaginationClass();
            pokeListViewModel.Pagination.Limit = (int)Math.Ceiling((double)repository.PokeCount / PAGESIZE);
            pokeListViewModel.Pagination.PageSize = page < pokeListViewModel.Pagination.Limit ? PAGESIZE : repository.PokeCount - ((pokeListViewModel.Pagination.Limit-1) * PAGESIZE);

            //pokeListViewModel.Pagination.PageSize = (page * PAGESIZE) > repository.PokeCount ? PAGESIZE - ((pokeListViewModel.Pagination.Limit * PAGESIZE) - repository.PokeCount) : PAGESIZE;
            pokeListViewModel.Pagination.Page = page < pokeListViewModel.Pagination.Limit ? page : pokeListViewModel.Pagination.Limit;

            //int offset = PAGESIZE * (pokeListViewModel.Pagination.Page - 1);

            //string path = $"https://pokeapi.co/api/v2/pokemon/?offset={offset}&limit={pokeListViewModel.Pagination.PageSize}";
            //PokeList pokeList = APIRequest(path).ToObject<PokeList>();

            pokeListViewModel.Pokemons = new List<Pokemon>();

            for (int i = (pokeListViewModel.Pagination.Page - 1) * PAGESIZE; i < ((pokeListViewModel.Pagination.Page - 1) * PAGESIZE) + pokeListViewModel.Pagination.PageSize; i++)
            {
                pokeListViewModel.Pokemons.Add(repository[(i+1).ToString()]);
            }
            
                //pokeListViewModel.Pokemons = repository.Pokemons;
            /*
            pokeListViewModel.Pokemons = new List<Pokemon>();
            foreach(var item in pokeList.results)
            {
                pokeListViewModel.Pokemons.Add(APIRequest(item.url).ToObject<Pokemon>());
            }
            */
            bool isAjaxCall = HttpContext.Request.Headers["x-requested-with"] == "XMLHttpRequest";
            
            if (isAjaxCall)
            {
                return PartialView("_PokeListing");
            }

            return View(pokeListViewModel);
        }

        public IActionResult Detail(string id = "1")
        {
            PokeDetailViewModel pokeDetail = new PokeDetailViewModel();
            pokeDetail.Pokemon = repository[id.ToLower()];
            
            if (pokeDetail.Pokemon != null)
            {
                pokeDetail.PokeMoves = new List<Models.PokemonMove.PokeMove>();
                //MOVES
                pokeDetail.Pokemon.moves.OrderBy(p => p.version_group_details.First().level_learned_at);
                foreach(var move in pokeDetail.Pokemon.moves)
                {
                    if (move.version_group_details.FirstOrDefault().move_learn_method.name == "level-up")
                    {
                        pokeDetail.PokeMoves.Add(repository.PokeMove(move.move.name,move.move.url));
                    }
                }

                //SPECIES
                pokeDetail.PokeSpecies = repository.PokeSpecies(pokeDetail.Pokemon.species.name, pokeDetail.Pokemon.species.url);

                //EVOLUTION
                pokeDetail.EvolutionChain = repository.EvolutionChain(pokeDetail.PokeSpecies.evolution_chain.url);
                pokeDetail.EvolutionChain.chain.evolves_to = GetEvoChain(pokeDetail.EvolutionChain.chain.evolves_to);

                //VIEWBAGS
                ViewBag.PokeCount = repository.PokeCount;

                return View(pokeDetail);
            }  
            else
                return View("NotFound404");
        }

        public List<Models.PokemonEvolution.EvolvesTo> GetEvoChain(List<Models.PokemonEvolution.EvolvesTo> evolvesTo)
        {
            foreach(var evo in evolvesTo)
            {
                evo.Pokemon = repository[evo.species.name];
                if (evo.evolves_to.Count > 0)
                    evo.evolves_to = GetEvoChain(evo.evolves_to);
            }
            return evolvesTo;
        }
    }
}