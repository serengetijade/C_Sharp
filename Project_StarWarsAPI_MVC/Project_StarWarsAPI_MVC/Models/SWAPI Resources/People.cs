using Newtonsoft.Json;
using Project_StarWarsAPI_MVC.Models.SWAPI_Resources;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Project_StarWarsAPI_MVC.Models.Content
{
    public class People
    {
        public int Id { get; set; }
        [DisplayName("Name")]
        public string name { get; set; }
        [DisplayName("Height")]
        public string height { get; set; }
        [DisplayName("Mass")]
        public string mass { get; set; }
        [DisplayName("Hair Color")]
        public string hair_color { get; set; }
        [DisplayName("Skin Color")]
        public string skin_color { get; set; }
        [DisplayName("Eye Color")]
        public string eye_color { get; set; }
        [DisplayName("Birth Year")]
        public string birth_year { get; set; }
        [DisplayName("Gender")]
        public string gender { get; set; }
        public string homeworld { get; set; }
        [NotMapped]
        [DisplayName("Films Array")]
        public string[]? films { get; set; }           //comma separated array
        [DisplayName("Films")]
        public string _films { get; set; }
        [NotMapped]
        [DisplayName("Species Array")]
        public string[]? species { get; set; }         //comma separated array
        [DisplayName("Species")]
        public string? _species { get; set; }
        [NotMapped]
        [DisplayName("Vehicles Array")]
        public string[]? vehicles { get; set; }    //comma separated array
        [DisplayName("Vehicles")]
        public string? _vehicles { get; set; }
        [NotMapped]
        [DisplayName("Starships Array")]
        public string[]? starships { get; set; }   //comma separated array
        [DisplayName("Starships")]
        public string? _starships { get; set; }
        [DisplayName("Created")]
        public string created { get; set; }
        [DisplayName("Edited")]
        public string edited { get; set; }
        [DisplayName("URL")]
        public string url { get; set; }
    }
}
