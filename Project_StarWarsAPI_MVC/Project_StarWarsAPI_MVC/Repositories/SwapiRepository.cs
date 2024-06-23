using Newtonsoft.Json;
using Project_StarWarsAPI_MVC.Interfaces;
using Project_StarWarsAPI_MVC.Models;
using Project_StarWarsAPI_MVC.Models.SwapiResponse;
namespace Project_StarWarsAPI_MVC.Repositories
{
    public class SwapiRepository : ISWAPIRepository
    {
        public HttpClient _httpClient { get; set; }
        private readonly ApplicationSettings _settings;

        public SwapiRepository(IConfiguration configuration, IHttpClientFactory httpClientFactory)
        {
            _settings = configuration.GetSection(nameof(ApplicationSettings)).Get<ApplicationSettings>();
            _httpClient = httpClientFactory.CreateClient(nameof(SwapiRepository));
            _httpClient.BaseAddress = new Uri(_settings.Swapi.ApiBaseUri);
        }

        public async Task<Result<Response>> Get(string target)
        {
            try
            {
                var response = await _httpClient.GetAsync(target);                          //GET request to the API: add the provided string to the base url address
                if (response.IsSuccessStatusCode)
                {
                    return Result.Fail<Response>(response.ReasonPhrase);
                }

                string jsonResponse = await response.Content.ReadAsStringAsync();           //Read the string from the response '.Content' //ReadASStringAsync is a method that reads asyncrhonously without holding up the main thread. 
                
                Response result = JsonConvert.DeserializeObject<Response>(jsonResponse);    //Parse API 'results':
                if (result.Count == 0)
                {
                    return Result.Fail<Response>("No results.");
                }

                return Result.Ok(result);
            }
            catch (Exception ex)
            {
                return Result.Fail<Response>(ex.Message);
            }
        }

        public async Task<Result<Response>> GetById(string target, string id)
        {
            Result<Response> result = await Get(target + "/" +  id);

            return result;
        }
    }
}