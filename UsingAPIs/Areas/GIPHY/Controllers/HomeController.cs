using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;
using UsingAPIs.Areas.GIPHY.Models;
using UsingAPIs.Models;

namespace UsingAPIs.Areas.GIPHY.Controllers
{
    [Area(nameof(GIPHY))]
    public class HomeController : Controller
    {
        private string _apiKey;

        public HomeController(IOptions<APIKeys> options)
        {
            _apiKey = options.Value.GIPHY;
        }

        public IActionResult Index(string search = "")
        {
            ViewBag.Search = search;
            var offset = "0";
            string method = "search";

            if(string.IsNullOrEmpty(search))
            {
                method = "trending";
            }

            //request
            WebRequest request = WebRequest.Create($"http://api.giphy.com/v1/gifs/{method}?api_key={_apiKey}&q={search}&offset={offset}");
            //response
            WebResponse response = request.GetResponse();
            //response stream
            Stream stream = response.GetResponseStream();
            //make it accessible
            StreamReader reader = new StreamReader(stream);
            //string - JSON
            string responseFromServer = reader.ReadToEnd();

            JObject parsedString = JObject.Parse(responseFromServer);

            Gif gifs = parsedString.ToObject<Gif>();

            return View(gifs);
        }


    }
}