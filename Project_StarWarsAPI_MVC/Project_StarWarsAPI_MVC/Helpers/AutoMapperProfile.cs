using AutoMapper;
using Project_StarWarsAPI_MVC.Models.Swapi;

namespace Project_StarWarsAPI_MVC.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() {
            CreateMap<BaseEntityResponse, BaseEntity>()
                .ForMember(
                dest => dest.Films,
                opt => opt.MapFrom(src => src.Films.ToList()))
                .ReverseMap();

            CreateMap<FilmResponse, Film>()
                .ReverseMap();

            CreateMap<PeopleResponse, People>()            
                .ReverseMap();  

            CreateMap<PlanetResponse, Planet>()            
                .ReverseMap();  

            CreateMap<SpeciesResponse, Species>()            
                .ReverseMap();  

            CreateMap<StarshipResponse, Starship>()            
                .ReverseMap();  

            CreateMap<VehicleResponse, Vehicle>()            
                .ReverseMap();
        }
    }
}