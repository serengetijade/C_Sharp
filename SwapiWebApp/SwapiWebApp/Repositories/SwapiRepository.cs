using SwapiWebApp.Repositories.Models;
using SwapiWebApp.Services.Models;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace SwapiWebApp.Repositories
{
    public interface ISwapiRepository
    {
        Task<ServiceResult<List<T>>> SendRequest<T>(string endpoint, bool getAllPages = false);
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

        public async Task<ServiceResult<List<T>>> SendRequest<T>(string endpoint, bool getAllPages = false)
        {
            try { 
                var jsonSerializerOptions = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

				var response = await _httpClient.GetAsync($"{endpoint}/");
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync();

                var allResults = new List<JsonObject>();
                var result = JsonSerializer.Deserialize<ApiResult>(content, jsonSerializerOptions);

                allResults.AddRange(result != null ? result.Results : new ());

				while (getAllPages && result != null && !string.IsNullOrWhiteSpace(result.Next))
                {
                    var nextResponse = await _httpClient.GetAsync(result.Next);
                    nextResponse.EnsureSuccessStatusCode();
                    var nextContent = await nextResponse.Content.ReadAsStringAsync();
                    if (string.IsNullOrWhiteSpace(nextContent))
                        break;
					var nextResult = JsonSerializer.Deserialize<ApiResult>(nextContent, jsonSerializerOptions) ?? new ();
                    allResults.AddRange(nextResult.Results);
                    result.Next = nextResult != null ? nextResult.Next : string.Empty;
				}

                var finalResults = JsonSerializer.Deserialize<List<T>>(
                    JsonSerializer.Serialize(allResults), jsonSerializerOptions) ?? new ();

                return new ServiceResult<List<T>>(true, "Request successful", finalResults);
			}
            catch (HttpRequestException ex)
            {
                return new ServiceResult<List<T>>(false, $"Request failed: {ex.Message}", new List<T>());
			}
        }
	}	
}