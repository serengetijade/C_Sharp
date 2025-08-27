using SwapiWebApp.Repositories.Models;
using SwapiWebApp.Services.Models;

namespace SwapiWebApp.Repositories
{
    public interface ISwapiRepository
    {
        
	}

	public class SwapiRepository : ISwapiRepository
	{
        private readonly HttpClient _httpClient;
        private readonly SwapiSettings _settings;

		public SwapiRepository(
            IConfiguration configuration, 
            IHttpClientFactory httpClientFactory, 
            SwapiSettings settings)
        {
			_settings = configuration.GetSection(nameof(SwapiSettings)).Get<SwapiSettings>()
                ?? throw new InvalidOperationException($"Unable to find ${nameof(SwapiSettings)} setup settings.");

			_httpClient = httpClientFactory.CreateClient("SwapiClient");
        }

        public async Task<ServiceResult<ApiResult>> SendRequest(string endpoint)
        {
            try { 
                var response = await _httpClient.GetAsync($"{endpoint}/");
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync();

                var result = System.Text.Json.JsonSerializer.Deserialize<ApiResult>(content, 
                    new System.Text.Json.JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    }
                );
				return new ServiceResult<ApiResult>(true, "Request successful", result);
            }
            catch (HttpRequestException ex)
            {
                return new ServiceResult<ApiResult>(false, $"Request failed: {ex.Message}", null);
			}
        }
	}	
}