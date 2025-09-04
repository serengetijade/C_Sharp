using SwapiWebApp.Services.Models;

namespace SwapiWebApp.Interfaces
{
    public interface ISwapiService
    {
		Task<ServiceResult<List<T>>> Get<T>(string endpoint, bool getAllPages = false);
		Task<ServiceResult<List<T>>> GetAll<T>(string endpoint);
	}
}