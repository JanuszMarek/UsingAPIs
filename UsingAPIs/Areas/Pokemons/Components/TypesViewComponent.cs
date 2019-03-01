using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsingAPIs.Areas.Pokemons.Models;
using UsingAPIs.Controllers;

namespace UsingAPIs.Areas.Pokemons.Components
{
    public class TypesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<string> Types = new List<string>();
            int i = 1;

            do
            {
                Types.Add(ExtendedController.APIRequest($"https://pokeapi.co/api/v2/type/{i}").ToObject<PokeType>().name);

            } while (!string.IsNullOrEmpty(Types.Last()));

            return View(Types);
        }
    }
}
