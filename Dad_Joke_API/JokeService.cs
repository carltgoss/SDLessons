using Dad_Joke_API.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Dad_Joke_API
{
    public class JokeService
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private readonly string baseURL = "https://us-central1-dadsofunny.cloudfunctions.net/DadJokes/random/jokes/";

        public async Task<Jokes> GetJokeAsync()
        {
            {
                HttpResponseMessage response = await _httpClient.GetAsync(baseURL);

                if (response.IsSuccessStatusCode)
                {
                    Jokes joke = await response.Content.ReadAsAsync<Jokes>();
                    return joke;
                }

                return null;
            }
        }
    }
}
