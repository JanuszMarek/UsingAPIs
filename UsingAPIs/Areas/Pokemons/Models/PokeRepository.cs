using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using UsingAPIs.Controllers;

namespace UsingAPIs.Areas.Pokemons.Models
{
    public class PokeRepository : IPokeRepository
    { 
        private Dictionary<string, Pokemon> pokemons;

        public int PokeCount => 807;
        public IEnumerable<Pokemon> Pokemons => pokemons.Values;

        public Pokemon this[string id]
        {
            get
            {
                return pokemons.ContainsKey(id) ? pokemons[id] : null;
            }
        }

        private async Task<Dictionary<string,Pokemon>> GetAllAsync()
        {
            var client = new HttpClient();
            //client.BaseAddress = new Uri("");
            Dictionary<string, Pokemon> dict = new Dictionary<string, Pokemon>();

            for (int i = 0; i < 807; i++)
            {
                var response = await client.GetAsync($"https://pokeapi.co/api/v2/pokemon/{i + 1}");
                response.EnsureSuccessStatusCode();
                var stringResult = await response.Content.ReadAsStringAsync();
                Pokemon pokemon = JsonConvert.DeserializeObject<Pokemon>(stringResult);
                dict.Add(pokemon.name, pokemon);
            }

            return dict;
            /*
            for (int i = 0; i < 807; i++)
            {
                //IRestResponse response = await client.ExecuteAsync(request)

               // Pokemon pok = await ExtendedController.APIRequest($"https://pokeapi.co/api/v2/pokemon/{i + 1}").ToObject<Pokemon>();
                list.Add(pok);
            }
            return list;
            */
        }

        public PokeRepository()
        {
            pokemons = GetAllAsync().Result;
            
        }

    }
}
