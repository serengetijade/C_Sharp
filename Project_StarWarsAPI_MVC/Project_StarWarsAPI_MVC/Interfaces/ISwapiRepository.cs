using Project_StarWarsAPI_MVC.Models;
using Project_StarWarsAPI_MVC.Models.SwapiResponses;

namespace Project_StarWarsAPI_MVC.Interfaces
{
    public interface ISWAPIRepository
    {
        Task<Result<Response>> Get(string target);
        Task<Result<Response>> GetById(string target, string id);
    }
}