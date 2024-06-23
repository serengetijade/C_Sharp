using Project_StarWarsAPI_MVC.Enums;
using Project_StarWarsAPI_MVC.Interfaces;
using Project_StarWarsAPI_MVC.Models;
using Project_StarWarsAPI_MVC.Repositories;

namespace Project_StarWarsAPI_MVC.Services
{
    public class SwapiService : ISwapiService
    {
        private readonly SwapiRepository _swapiRepository;

        public SwapiService (SwapiRepository swapiRepository)
        {
            _swapiRepository = swapiRepository;
        }

        public async Task<Result<T>> Get<T>(SwapiTargetEnum target)
        {
            var result = await _swapiRepository.Get(target.ToString());

            //Map from response to result

            return null;
        }

        public async Task<Result<T>> GetById<T>(SwapiTargetEnum target, string id)
        {    
            var result = await _swapiRepository.GetById(target.ToString(), id);

            return null;
        }
    }
}