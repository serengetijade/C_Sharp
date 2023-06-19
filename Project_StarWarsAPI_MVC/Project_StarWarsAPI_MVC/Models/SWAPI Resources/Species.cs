using Project_StarWarsAPI_MVC.Models.Content;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_StarWarsAPI_MVC.Models.SWAPI_Resources
{
    public class Species
    {
        public int Id { get; set; }
        [DisplayName("Name")]
        public string name { get; set; }
        [DisplayName("Classifiction")]
        public string classification { get; set; }
        [DisplayName("Designation")]
        public string designation { get; set; }
        [DisplayName("Avg Height")]
        public string average_height { get; set; }
        [DisplayName("Avg Lifespan")]
        public string average_lifespan { get; set; }
        [DisplayName("EyeColor")]
        public string eye_colors { get; set; }
        [DisplayName("Hair Colors")]
        public string hair_colors { get; set; }
        [DisplayName("Skin Colors")]
        public string skin_colors { get; set; }
        [DisplayName("Language")]
        public string language { get; set; }
        [DisplayName("Homeworld")]
        public string? homeworld { get; set; }
        [NotMapped]
        [DisplayName("People Array")]
        public string[]? people { get; set; }   //comma separated array
        [DisplayName("People")]
        public string? _people { get; set; }
        [NotMapped]
        [DisplayName("Films Array")]
        public string[]? films { get; set; }    //comma separated array
        [DisplayName("Films")]
        public string? _films { get; set; }
        [DisplayName("Created")]
        public string created { get; set; }
        [DisplayName("Edited")]
        public string edited { get; set; }
        [DisplayName("URL")]
        public string url { get; set; }
    }
}
