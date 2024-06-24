using Project_StarWarsAPI_MVC.Models;
using Project_StarWarsAPI_MVC.Models.SwapiResponses;

namespace Project_StarWarsAPI_MVC.Interfaces
{
    public interface ISWAPIRepository
    {
        Task<Result<SwapiResponse>> Get(string target);
        Task<Result<SwapiResponse>> GetById(string target, string id);
    }
}