using AutoMapper;
using Project_StarWarsAPI_MVC.Models.SwapiEntities;
using Project_StarWarsAPI_MVC.Models.SwapiResponses;
using Project_StarWarsAPI_MVC.Models.ViewModels;

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
            CreateMap<BaseEntity, BaseEntityViewModel>()
                .ForMember(
                dest => dest.Films,
                opt => opt.MapFrom(src => src.Films.ToList()))
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
            CreateMap<Film, FilmViewModel>()
                .ForMember(
                dest => dest.Characters,
                opt => opt.MapFrom(src => src.Characters.ToList()))
                .ForMember(
                dest => dest.Planets,
                opt => opt.MapFrom(src => src.Planets.ToList()))
                .ForMember(
                dest => dest.Species,
                opt => opt.MapFrom(src => src.Species.ToList()))
                .ForMember(
                dest => dest.Starships,
                opt => opt.MapFrom(src => src.Starships.ToList()))
                .ForMember(
                dest => dest.Vehicles,
                opt => opt.MapFrom(src => src.Vehicles.ToList()))
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
                opt => opt.MapFrom(src => string.Join(",", src.Vehicles)))
                .ReverseMap(); 
            CreateMap<People, PeopleViewModel>()
                .ForMember(
                dest => dest.Species,
                opt => opt.MapFrom(src => src.Species.ToList()))
                .ForMember(
                dest => dest.Starships,
                opt => opt.MapFrom(src => src.Starships.ToList()))
                .ForMember(
                dest => dest.Vehicles,
                opt => opt.MapFrom(src => src.Vehicles.ToList()))
                .ReverseMap();  

            CreateMap<PlanetResponse, Planet>()
                .ForMember(
                dest => dest.Residents,
                opt => opt.MapFrom(src => string.Join(",", src.Residents)))
                .ReverseMap(); 
            CreateMap<Planet, PlanetViewModel>()
                .ForMember(
                dest => dest.Residents,
                opt => opt.MapFrom(src => src.Residents.ToList()))
                .ReverseMap();  

            CreateMap<SpeciesResponse, Species>()
                .ForMember(
                dest => dest.People,
                opt => opt.MapFrom(src => string.Join(",", src.People)))
                .ReverseMap();
            CreateMap<Species, SpeciesViewModel>()
                .ForMember(
                dest => dest.People,
                opt => opt.MapFrom(src => src.People.ToList()))
                .ReverseMap();   

            CreateMap<StarshipResponse, Starship>()
                .ForMember(
                dest => dest.Image,
                opt => opt.MapFrom(src => string.Join(",", src.Image)))
                .ForMember(
                dest => dest.Pilots,
                opt => opt.MapFrom(src => string.Join(",", src.Pilots)))
                .ReverseMap();
            CreateMap<Starship, StarshipViewModel>()
                .ForMember(
                dest => dest.Image,
                opt => opt.MapFrom(src => src.Image.ToList()))
                .ForMember(
                dest => dest.Pilots,
                opt => opt.MapFrom(src => src.Pilots.ToList()))
                .ReverseMap();

            CreateMap<VehicleResponse, Vehicle>()
                .ForMember(
                dest => dest.Pilots,
                opt => opt.MapFrom(src => string.Join(",", src.Pilots)))
                .ReverseMap();   
            CreateMap<Vehicle, VehicleViewModel>()
                .ForMember(
                dest => dest.Pilots,
                opt => opt.MapFrom(src => src.Pilots.ToList()))
                .ReverseMap();
        }
    }
}