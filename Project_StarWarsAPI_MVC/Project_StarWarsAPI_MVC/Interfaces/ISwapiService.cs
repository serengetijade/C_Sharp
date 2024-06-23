using Project_StarWarsAPI_MVC.Enums;
using Project_StarWarsAPI_MVC.Models;

namespace Project_StarWarsAPI_MVC.Interfaces
{
    public interface ISwapiService
    {
        Task<Result<T>> Get<T>(SwapiTargetEnum target);
        Task<Result<T>> GetById<T>(SwapiTargetEnum target, string id);
    }
}