using SwapiWebApp.Services.Models;

namespace SwapiWebApp.Interfaces
{
    public interface ISwapiRepository
    {
        Task<ServiceResult<List<T>>> GetDataAsync<T>(string endpoint, bool getAllPages = false);
    }
}
