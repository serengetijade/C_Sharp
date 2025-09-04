using Project_StarWarsAPI_MVC.Models.Swapi;
using SwapiWebApp.Interfaces;
using System.Text;

namespace SwapiWebApp.Data
{
    public class SeedData
    {
        public static async Task Initialize(IServiceProvider serviceProvider)
        {
            SwapiContext context = serviceProvider.GetRequiredService<SwapiContext>();
            ISwapiService _swapiService = serviceProvider.GetRequiredService<ISwapiService>();

            if (!context.Starship.Any())
            {
                var films = await _swapiService.GetAll<Film>("films");
                var people = await _swapiService.GetAll<People>("people");
                var planets = await _swapiService.GetAll<Planet>("planets");
                var species = await _swapiService.GetAll<Species>("species");
			    var starships = await _swapiService.GetAll<Starship>("starships");
                var vehicles = await _swapiService.GetAll<Vehicle>("vehicles");

                foreach (var item in films.Content)
                {
                    var characterList = people.Content
                        .Where(people => item.Characters != null && item.Characters.Contains(people.Url)).ToList();
                    item.CharactersList = characterList;

                    var planetList = planets.Content
                        .Where(planet => item.Planets != null && item.Planets.Contains(planet.Url)).ToList();
                    item.PlanetsList = planetList;

                    var specilList = species.Content
                        .Where(species => item.Species != null && item.Species.Contains(species.Url)).ToList();
                    item.SpeciesList = specilList;

                    var starshipList = starships.Content
                        .Where(starship => item.Starships != null && item.Starships.Contains(starship.Url)).ToList();
                    item.StarshipsList = starshipList;

                    var vehicleList = vehicles.Content
                        .Where(vehicle => item.Vehicles != null && item.Vehicles.Contains(vehicle.Url)).ToList();
                    item.VehiclesList = vehicleList;
                }

                foreach (var item in people.Content)
                {
					var filmList = films.Content
                        .Where(film => item.Films != null && item.Films.Contains(film.Url)).ToList();
					item.FilmsList = filmList;

                    var specilList = species.Content
                        .Where(species => item.Species != null && item.Species.Contains(species.Url)).ToList();
                    item.SpeciesList = specilList;

                    var starshipList = starships.Content
                        .Where(starship => item.Starships != null && item.Starships.Contains(starship.Url)).ToList();
                    item.StarshipsList = starshipList;

                    var vehicleList = vehicles.Content
                        .Where(vehicle => item.Vehicles != null && item.Vehicles.Contains(vehicle.Url)).ToList();
                    item.VehiclesList = vehicleList;
				}

                foreach (var item in planets.Content)
                {
                    var filmList = films.Content
                        .Where(film => item.Films != null && item.Films.Contains(film.Url)).ToList();
                    item.FilmsList = filmList;

                    var residentList = people.Content
                        .Where(people => item.Residents != null && item.Residents.Contains(people.Url)).ToList();
                    item.ResidentsList = residentList;
				}

                foreach (var item in species.Content)
                {
                    var filmList = films.Content
                        .Where(film => item.Films != null && item.Films.Contains(film.Url)).ToList();
                    item.FilmsList = filmList;

                    var peopleList = people.Content
                        .Where(people => item.People != null && item.People.Contains(people.Url)).ToList();
                    item.PeopleList = peopleList;
				}

                foreach (var item in starships.Content)
                {
                    var filmList = films.Content
                        .Where(film => item.Films != null && item.Films.Contains(film.Url)).ToList();
                    item.FilmsList = filmList;

                    var peopleList = people.Content
                        .Where(people => item.Pilots != null && item.Pilots.Contains(people.Url)).ToList();
                    item.PilotsList = peopleList;
                }

                foreach (var item in vehicles.Content)
                {
                    var filmList = films.Content
                        .Where(film => item.Films != null && item.Films.Contains(film.Url)).ToList();
                    item.FilmsList = filmList;

                    var peopleList = people.Content
                        .Where(people => item.Pilots != null && item.Pilots.Contains(people.Url)).ToList();
                    item.PilotsList = peopleList;
				}

				context.Films.AddRange(films.Content);
                context.People.AddRange(people.Content);
                context.Planets.AddRange(planets.Content);
                context.Species.AddRange(species.Content);
                context.Starship.AddRange(starships.Content);
                context.Vehicle.AddRange(vehicles.Content);
			}

            context.SaveChanges();
            context.Dispose();
        }

        public static string ArrayToStringConverter(string[]? results)
        {
            StringBuilder result = new StringBuilder();
            int counter = 0;
            foreach (string item in results)
            {
                counter++;
                if (counter < results.Length)
                {
                    result.Append(item + ", ");
                }
                else
                {
                    result.Append(item);
                }
            }
            return result.ToString();
        }

        public static string[] StringToArray(string record)
        {
            if (record != null)
            {
                string[] urlArray = record.Split(", ");
                return urlArray;
            }
            else
            {
                string[] urlArray = null;
                return urlArray;
            }
        }
    }
}