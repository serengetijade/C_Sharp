using Newtonsoft.Json;
using Project_StarWarsAPI_MVC.Interfaces;
using Project_StarWarsAPI_MVC.Models;
using Project_StarWarsAPI_MVC.Models.SwapiResponses;

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
            _httpClient.BaseAddress = new Uri(_settings.SwapiSettings.ApiBaseUri);
        }

        public async Task<Result<SwapiResponse>> Get(string target)
        {
            //ToDo: get all paged results
            try
            {
                var response = await _httpClient.GetAsync(target.ToLower());                          //GET request to the API: add the provided string to the base url address
                if (!response.IsSuccessStatusCode)
                {
                    return Result.Fail<SwapiResponse>(response.ReasonPhrase);
                }

                string jsonResponse = await response.Content.ReadAsStringAsync();           //Read the string from the response '.Content' //ReadASStringAsync is a method that reads asyncrhonously without holding up the main thread. 
                
                SwapiResponse result = JsonConvert.DeserializeObject<SwapiResponse>(jsonResponse);    //Parse API 'results':
                if (result.Count == 0)
                {
                    return Result.Fail<SwapiResponse>("No results.");
                }

                return Result.Ok(result);
            }
            catch (Exception ex)
            {
                return Result.Fail<SwapiResponse>(ex.Message);
            }
        }

        public async Task<Result<SwapiResponse>> GetById(string target, string id)
        {
            Result<SwapiResponse> result = await Get(target + "/" +  id);

            return result;
        }
    }
}