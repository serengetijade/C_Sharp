using Newtonsoft.Json;
using Project_StarWarsAPI_MVC.Interfaces;
using Project_StarWarsAPI_MVC.Models.Swapi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Project_StarWarsAPI_MVC.Repositories
{
    public class SwapiRepository : ISWAPIRepository
    {
        public HttpClient _httpClient { get; set; }
        private readonly ApplicationSettings _settings;

        public SwapiRepository(IConfiguration configuration, IHttpClientFactory httpClientFactory)
        {
            _settings = configuration.GetSection(nameof(ApplicationSettings)).Get<ApplicationSettings>();
            _httpClient = httpClientFactory.CreateClient("SWAPIC");
            _httpClient.BaseAddress = new Uri(_settings.Swapi.ApiBaseUri);
        }

        public async Task<ApiResult> Get(string target)
        {
            var response = await _httpClient.GetAsync(target);                     //GET request to the API: add the provided string to the base url address
            string jsonResponse = await response.Content.ReadAsStringAsync();             //Read the string from the response '.Content' //ReadASStringAsync is a method that reads asyncrhonously without holding up the main thread. 
            ApiResult result = JsonConvert.DeserializeObject<ApiResult>(jsonResponse);    //Parse API 'results':

            return result;
        }
    }
}