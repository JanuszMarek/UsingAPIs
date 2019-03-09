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
        private List<PokeMove> pokeMoves;
        private List<PokeSpecies> pokeSpecies;
        private Dictionary<string,PokeEvolutionChain> evolutionChains;

        //PUBLIC
        public int PokeCount => 807;
        public Pokemon this[string name]
        {
            get
            {
                bool isNew = false;
                int id;
                if (int.TryParse(name, out id))
                {
                    Pokemon pokemon = CheckGetRepo<Pokemon>(pokemons.FirstOrDefault(p => p.id == id), Pokemon.ApiName, id.ToString(), out isNew);
                    if(isNew)
                    {
                        pokemons.Add(pokemon);
                    }
                    return pokemon;
                }
                else
                {
                    Pokemon pokemon = CheckGetRepo<Pokemon>(pokemons.FirstOrDefault(p => p.name == name), Pokemon.ApiName, name, out isNew);
                    if (isNew)
                    {
                        pokemons.Add(pokemon);
                    }
                    return pokemon;
                }

            }
        }

        public PokeMove PokeMove(string name, string path)
        {
            bool isNew = false;
            PokeMove pokeMove = CheckGetRepo<PokeMove>(pokeMoves.FirstOrDefault(p => p.name == name), path, out isNew);
            if (isNew)
            {
                pokeMoves.Add(pokeMove);
            }
            return pokeMove;   
        }
        
        public PokeSpecies PokeSpecies(string name, string path)
        {
            bool isNew = false;
            PokeSpecies pokeSpec = CheckGetRepo<PokeSpecies>(pokeSpecies.FirstOrDefault(p => p.name == name), path, out isNew);
            if (isNew)
            {
                pokeSpecies.Add(pokeSpec);
            }
            return pokeSpec;
        }

        public PokeEvolutionChain EvolutionChain(string path)
        {
            
            bool isNew = false;
            PokeEvolutionChain pokeEvolution  = CheckGetRepo<PokeEvolutionChain>(evolutionChains.ContainsKey(path) ? evolutionChains[path] : null, path, out isNew);
            if (isNew)
            {
                evolutionChains.Add(path, pokeEvolution);
            }
            return pokeEvolution;
        }
        
        //CONSTRUCTOR
        public PokeRepository()
        {
            pokemons = new List<Pokemon>();
            pokeMoves = new List<PokeMove>();
            pokeSpecies = new List<PokeSpecies>();
            evolutionChains = new Dictionary<string, PokeEvolutionChain>();
        }

        //METHODS
        /*
        private async Task<Pokemon> GetPokemonAsync(string name)
        {
            var client = new HttpClient();
            var response = await client.GetAsync($"https://pokeapi.co/api/v2/pokemon/{name}");
            if (response.IsSuccessStatusCode)
            {
                var stringResult = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Pokemon>(stringResult);
            }
            return null;
        }
        */

        private async Task<T> GetDataAsync<T>(string type, string id)
        {
            return await GetDataAsync<T>($"https://pokeapi.co/api/v2/{type}/{id}");
        }
        private async Task<T> GetDataAsync<T>(string path)
        {
            //GET DATA FROM API
            var client = new HttpClient();
            var response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                var stringResult = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(stringResult);
            }
            return default(T);
        }

        private T CheckGetRepo<T>(T obj, string type, string id, out bool isNew)
        {
            isNew = false;
            return CheckGetRepo<T>(obj, $"https://pokeapi.co/api/v2/{type}/{id}", out isNew);
        }

        private T CheckGetRepo<T>(T obj, string path, out bool isNew)
        {
            isNew = false;
            if (obj != null)
            {
                return obj;
            }
            else
            {
                var result = GetDataAsync<T>(path);
                if (result.Result != null)
                {
                    isNew = true;
                    return result.Result;
                }
                else
                    return default(T);
            }
        }
    }
}
