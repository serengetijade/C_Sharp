using SwapiWebApp.Interfaces;
using SwapiWebApp.Services.Models;

namespace SwapiWebApp.Services
{
    public class SwapiService : ISwapiService
	{
		public readonly ISwapiRepository _swapiRepository;

		public SwapiService(
			ISwapiRepository swapiRepository
			)
        {
			_swapiRepository = swapiRepository ?? throw new ArgumentNullException(nameof(swapiRepository));
		}

		public async Task<ServiceResult<List<T>>> Get<T>(string endpoint, bool getAllPages = false)
		{
			var result = await _swapiRepository.GetDataAsync<T>(endpoint, getAllPages);
			return result;
		}

		public async Task<ServiceResult<List<T>>> GetAll<T>(string endpoint)
		{
			var result = await _swapiRepository.GetDataAsync<T>(endpoint, true);
			return result;
		}
	}
}