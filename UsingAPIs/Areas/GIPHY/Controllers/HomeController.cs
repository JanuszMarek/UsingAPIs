using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace UsingAPIs.Areas.GIPHY.Controllers
{
    [Area(nameof(GIPHY))]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string apiKey = "";


            //request
            WebRequest request = WebRequest.Create($"http://api.giphy.com/v1/gifs/search?q=funny+cat&api_key={apiKey}");
            //response
            WebResponse response = request.GetResponse();
            //response stream
            Stream stream = response.GetResponseStream();
            //make it accessible
            StreamReader reader = new StreamReader(stream);
            //string - JSON
            string responseFromServer = reader.ReadToEnd();

            JObject parsedString = JObject.Parse(responseFromServer);

            return View();
        }


    }
}