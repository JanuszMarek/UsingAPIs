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
        public IActionResult Index(string path = "https://pokeapi.co/api/v2/pokemon/")
        {
            PokeList pokeList = APIRequest(path).ToObject<PokeList>();
            ViewBag.StartNo = 0;

            return View(pokeList);
        }

        public IActionResult Detail(string id = "1")
        {
            string path = $"https://pokeapi.co/api/v2/pokemon/{id}/";

            Pokemon pokemon = APIRequest(path).ToObject<Pokemon>();

            return View(pokemon);
        }
    }
}