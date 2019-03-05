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
        //PRIVATE
        private List<Pokemon> pokemons;
        private PokeList pokeList;

        //PUBLIC
        public int PokeCount => 807;
        //public IEnumerable<Pokemon> Pokemons => pokemons.Values;
        public Pokemon this[string name]
        {
            get
            {
                int id;
                if(int.TryParse(name, out id))
                {
                    var pok = pokemons.FirstOrDefault(p => p.id == id);
                    if (pok != null)
                    {
                        return pok;
                    }
                    else
                    {
                        var searchname = pokeList.results.ElementAt(id-1).name;
                        pokemons.Add(GetPokemonAsync(searchname).Result);
                        return pokemons.FirstOrDefault(p => p.name == searchname);
                    }
                }
                else
                {
                    var pok = pokemons.FirstOrDefault(p => p.name == name);
                    if (pok != null)
                    {
                        return pok;
                    }
                    else
                    {
                        pokemons.Add(GetPokemonAsync(name).Result);
                        return pokemons.FirstOrDefault(p => p.name == name);
                    }
                }

            }
        }

        //CONSTRUCTOR
        public PokeRepository()
        {
            pokeList = GetPokeListAsync($"https://pokeapi.co/api/v2/pokemon?offset=0&limit={PokeCount}").Result;
            pokemons = new List<Pokemon>();
            //pokemons = GetAllAsync().Result;

        }

        //METHODS
        private async Task<PokeList> GetPokeListAsync(string path)
        {
            var client = new HttpClient();
            var response = await client.GetAsync(path);

            response.EnsureSuccessStatusCode();

            var stringResult = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<PokeList>(stringResult);
        }

        private async Task<Pokemon> GetPokemonAsync(string name)
        {
            var client = new HttpClient();
            var response = await client.GetAsync($"https://pokeapi.co/api/v2/pokemon/{name}");
            response.EnsureSuccessStatusCode();
            var stringResult = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Pokemon>(stringResult);

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



    }
}
