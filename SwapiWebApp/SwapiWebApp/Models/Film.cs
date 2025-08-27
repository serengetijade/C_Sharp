using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_StarWarsAPI_MVC.Models.Swapi
{
    public class Film
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [DisplayName("Episode ID")]
        public string Episode_Id { get; set; }
        [DisplayName("Opening Crawl")]
        public string Opening_Crawl { get; set; }
        public string Director { get; set; }
        public string Producer { get; set; }
        [DisplayName("Release Date")]
        public string Release_Date { get; set; }
        [NotMapped]
        public string[]? Species { get; set; }
        [DisplayName("Species")]
        public List<Species> SpeciesList { get; set; }
        [NotMapped]
        public string[]? Starships {get; set; }
        [DisplayName("Starships")]
        public List<Starship> StarshipsList { get; set; }
        [NotMapped]
        public string[]? Vehicles { get; set; }
        [DisplayName("Vehicles")]
        public List<Vehicle> VehiclesList { get; set; }
        [NotMapped]
        public string[] Characters { get; set; }
        [DisplayName("Characters")]
        public List<People> CharactersList { get; set; }
        [NotMapped]
        public string[]? Planets { get; set; }
        [DisplayName("Planets")]
        public List<Planet> PlanetsList { get; set; }
    }
}