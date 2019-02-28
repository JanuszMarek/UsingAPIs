using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using UsingAPIs.Areas.Pokemons.Models;

namespace UsingAPIs.Areas.Pokemons.Controllers
{
    [Area(nameof(Pokemons))]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail()
        {
            //request
            WebRequest request = WebRequest.Create("https://pokeapi.co/api/v2/pokemon/1/");
            //response
            WebResponse response = request.GetResponse();
            //response stream
            Stream stream = response.GetResponseStream();
            //make it accessible
            StreamReader reader = new StreamReader(stream);
            //string - JSON
            string responseFromServer = reader.ReadToEnd();

            JObject parsedString = JObject.Parse(responseFromServer);

            Pokemon pokemon = parsedString.ToObject<Pokemon>();

            return View(pokemon);
        }
    }
}