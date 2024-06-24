using AutoMapper;
using Project_StarWarsAPI_MVC.Enums;
using Project_StarWarsAPI_MVC.Interfaces;
using Project_StarWarsAPI_MVC.Models;
using Project_StarWarsAPI_MVC.Models.SwapiResponses;

namespace Project_StarWarsAPI_MVC.Services
{
    public class SwapiService : ISwapiService
    {
        private readonly IMapper _mapper;
        private readonly ISWAPIRepository _swapiRepository;

        public SwapiService (IMapper mapper, ISWAPIRepository swapiRepository)
        {
            this._mapper = mapper;
            this._swapiRepository = swapiRepository;
        }

        public async Task<Result<T>> Get<T>(SwapiTargetEnum target) where T : class 
        {
            Result<SwapiResponse> response = await _swapiRepository.Get(target.ToString());

            if (!response.Success) return Result.Fail<T>(response.Message);

            T result = _mapper.Map<T>(response.Content);

            return Result.Ok(result);
        }

        public async Task<Result<T>> GetById<T>(SwapiTargetEnum target, string id)
        {    
            var response = await _swapiRepository.GetById(target.ToString(), id);

            if (!response.Success) return Result.Fail<T>(response.Message);

            T result = _mapper.Map<T>(response.Content);

            return Result.Ok(result);
        }
    }
}