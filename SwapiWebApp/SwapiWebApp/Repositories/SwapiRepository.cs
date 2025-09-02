using SwapiWebApp.Interfaces;
using SwapiWebApp.Repositories.Models;
using SwapiWebApp.Services.Models;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace SwapiWebApp.Repositories
{
    public class SwapiRepository : ISwapiRepository
    {
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions _jsonSerializerOptions;
        private readonly ILogger<SwapiRepository> _logger;
        private readonly SwapiSettings _settings;

		public SwapiRepository(
            IConfiguration configuration, 
            IHttpClientFactory httpClientFactory, 
            ILogger<SwapiRepository> logger,
			SwapiSettings settings)
        {
            _settings = configuration.GetSection(nameof(SwapiSettings)).Get<SwapiSettings>()
                ?? throw new InvalidOperationException($"Unable to find ${nameof(SwapiSettings)} setup settings.");            
            _httpClient = httpClientFactory.CreateClient("SwapiClient");            
            _jsonSerializerOptions = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower
            };
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<ServiceResult<List<T>>> SendRequest<T>(string endpoint, bool getAllPages = false)
        {
            try {
                var allResults = new List<JsonObject>();
                
				var response = await FetchAsync($"{endpoint}/");
				if (!response.Success)
				{
					return new ServiceResult<List<T>>(success: false, response.Message, new List<T>());
				}

				allResults.AddRange(response.Content.Results != null ? response.Content.Results : new());

				var nextUrl = response.Content?.Next;
				while (getAllPages && !string.IsNullOrWhiteSpace(nextUrl))
                {
					var nextResponse = await FetchAsync(nextUrl);
					if (!nextResponse.Success)
					{
						nextUrl = null;
						break;
					}

					allResults.AddRange(nextResponse.Content?.Results != null ? nextResponse.Content.Results : new());
					
                    nextUrl = nextResponse.Content?.Next != null ? nextResponse.Content?.Next : null;
				}

                var finalResults = DeserializeResults<T>(allResults);

                return new ServiceResult<List<T>>(success: true, $"Request successful. {finalResults.Count} records retrieved.", finalResults);
			}
            catch (HttpRequestException ex)
            {
                return new ServiceResult<List<T>>(success: false, $"Request failed: {ex.Message}", new List<T>());
			}
        }

		private async Task<ServiceResult<ApiResult>> FetchAsync(string url)
		{
			try
			{
				using var response = await _httpClient.GetAsync(url);
				response.EnsureSuccessStatusCode();

				var content = await response.Content.ReadAsStringAsync();
				if (string.IsNullOrWhiteSpace(content))
				{
					return new ServiceResult<ApiResult>(success: false, "Empty response received", new ApiResult());
				}

				var result = JsonSerializer.Deserialize<ApiResult>(content, _jsonSerializerOptions) ?? new ApiResult();
				
				return new ServiceResult<ApiResult>(true, "Page fetched successfully", result);
			}
			catch (HttpRequestException ex)
			{
				var message = $"Failed to fetch page from {url}: {ex.Message}";
				_logger.LogError(ex, message);
				return new ServiceResult<ApiResult>(false, message, new ApiResult());
			}
		}

		private List<T> DeserializeResults<T>(List<JsonObject> jsonObjects)
		{
			try
			{
				var serializedResults = JsonSerializer.Serialize(jsonObjects);
				return JsonSerializer.Deserialize<List<T>>(serializedResults, _jsonSerializerOptions) ?? new List<T>();
			}
			catch (JsonException ex)
			{
				_logger.LogError(ex, $"Failed to deserialize results to type {typeof(T).Name}");
				return new List<T>();
			}
		}
	}	
}