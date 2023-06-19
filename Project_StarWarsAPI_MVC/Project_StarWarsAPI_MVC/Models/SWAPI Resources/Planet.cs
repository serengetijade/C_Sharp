using Project_StarWarsAPI_MVC.Models.Content;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_StarWarsAPI_MVC.Models.SWAPI_Resources
{
    public class Planet
    {
        public int Id { get; set; }
        [DisplayName("Name")]
        public string name { get; set; }
        [DisplayName("Diameter")]
        public string diameter { get; set; }
        [DisplayName("Rotation Period")]
        public string rotation_period { get; set; }
        [DisplayName("Orbital Period")]
        public string orbital_period { get; set; }
        [DisplayName("Gravity")]
        public string gravity { get; set; }
        [DisplayName("Population")]
        public string population { get; set; }
        [DisplayName("Climate")]
        public string climate { get; set; }
        [DisplayName("Terrain")]
        public string terrain { get; set; }
        [DisplayName("Surface Water")]
        public string surface_water { get; set; }
        [NotMapped]
        [DisplayName("Residents Array")]
        public string[]? residents { get; set; }  //comma separated array
        [DisplayName("Residents")]
        public string? _residents { get; set; }
        [NotMapped]
        [DisplayName("Films Array")]
        public string[]? films { get; set; }       //comma separated array
        [DisplayName("Films")]
        public string? _films { get; set; }
        [DisplayName("URL")]
        public string url { get; set; }
        [DisplayName("Created")]
        public string created { get; set; }
        [DisplayName("Edited")]
        public string edited { get; set; }
    }
}
