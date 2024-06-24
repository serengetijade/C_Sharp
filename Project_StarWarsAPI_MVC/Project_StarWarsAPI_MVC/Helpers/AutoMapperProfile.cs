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
                opt => opt.MapFrom(src => string.Join(",", src.Films)))
                .ReverseMap();

            CreateMap<FilmResponse, Film>()
                .ForMember(
                dest => dest.Characters,
                opt => opt.MapFrom(src => string.Join(",", src.Characters)))
                .ForMember(
                dest => dest.Planets,
                opt => opt.MapFrom(src => string.Join(",", src.Planets)))
                .ForMember(
                dest => dest.Species,
                opt => opt.MapFrom(src => string.Join(",", src.Species)))
                .ForMember(
                dest => dest.Starships,
                opt => opt.MapFrom(src => string.Join(",", src.Starships)))
                .ForMember(
                dest => dest.Vehicles,
                opt => opt.MapFrom(src => string.Join(",", src.Vehicles)))
                .ReverseMap();

            CreateMap<PeopleResponse, People>()
                .ForMember(
                dest => dest.Species,
                opt => opt.MapFrom(src => string.Join(",", src.Species)))
                .ForMember(
                dest => dest.Starships,
                opt => opt.MapFrom(src => string.Join(",", src.Starships)))
                .ForMember(
                dest => dest.Vehicles,
                opt => opt.MapFrom(src => string.Join(",", src.Vehicles.ToString)))
                .ReverseMap();  

            CreateMap<PlanetResponse, Planet>()
                .ForMember(
                dest => dest.Residents,
                opt => opt.MapFrom(src => string.Join(",", src.Residents)))
                .ReverseMap();  

            CreateMap<SpeciesResponse, Species>()
                .ForMember(
                dest => dest.People,
                opt => opt.MapFrom(src => string.Join(",", src.People)))
                .ReverseMap();  

            CreateMap<StarshipResponse, Starship>()
                .ForMember(
                dest => dest.Image,
                opt => opt.MapFrom(src => string.Join(",", src.Image)))
                .ForMember(
                dest => dest.Pilots,
                opt => opt.MapFrom(src => string.Join(",", src.Pilots)))
                .ReverseMap();  

            CreateMap<VehicleResponse, Vehicle>()            
                .ReverseMap();
        }
    }
}