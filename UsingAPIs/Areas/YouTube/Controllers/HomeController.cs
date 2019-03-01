using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using UsingAPIs.Areas.YouTube.Models;
using UsingAPIs.Controllers;
using UsingAPIs.Models;

namespace UsingAPIs.Areas.YouTube.Controllers
{
    [Area(nameof(YouTube))]
    public class HomeController : ExtendedController
    {
        private string _apiKey;

        public HomeController(IOptions<APIKeys> options)
        {
            _apiKey = options.Value.YouTube;
        }

        public IActionResult Index(string search="", string token="")
        {
            if(!string.IsNullOrEmpty(_apiKey))
            {

                string path = $"https://www.googleapis.com/youtube/v3/search?part=snippet&pageToken={token}&maxResults=12&q={search}&regionCode=pl&relevanceLanguage=pl&type=video&key={_apiKey}";
                YouTubeSearch ytsearch = APIRequest(path).ToObject<YouTubeSearch>();

                ViewBag.Search = search;

                return View(ytsearch);
            }
            else
            {
                return View("NoKey");
            }
        }
    }
}