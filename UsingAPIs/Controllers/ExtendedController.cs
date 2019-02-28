using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace UsingAPIs.Controllers
{
    public class ExtendedController : Controller
    {
        public static JObject APIRequest(string requestPath)
        {
            //request
            WebRequest request = WebRequest.Create(requestPath);
            //response
            WebResponse response = request.GetResponse();
            //response stream
            Stream stream = response.GetResponseStream();
            //make it accessible
            StreamReader reader = new StreamReader(stream);
            //string - JSON
            string responseFromServer = reader.ReadToEnd();

            JObject parsedString = JObject.Parse(responseFromServer);

            return parsedString;
        }
    }
}