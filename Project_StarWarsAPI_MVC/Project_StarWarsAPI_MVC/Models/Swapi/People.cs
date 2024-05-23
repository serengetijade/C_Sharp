using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_StarWarsAPI_MVC.Models.Swapi
{
    public class People : BaseEntity
    {
        [DisplayName("Height")]
        public string Height { get; set; }
        [DisplayName("Mass")]
        public string mass { get; set; }
        [DisplayName("Hair Color")]
        public string Hair_Color { get; set; }
        [DisplayName("Skin Color")]
        public string Skin_Color { get; set; }
        [DisplayName("Eye Color")]
        public string Eye_Color { get; set; }
        [DisplayName("Birth Year")]
        public string Birth_Year { get; set; }
        [DisplayName("Gender")]
        public string Gender { get; set; }
        public string Homeworld { get; set; }
        [NotMapped]
        [DisplayName("Species Array")]
        public string[]? Species { get; set; }         //comma separated array
        [DisplayName("Species")]
        public string? _Species { get; set; }
        [NotMapped]
        [DisplayName("Vehicles Array")]
        public string[]? Vehicles { get; set; }    //comma separated array
        [DisplayName("Vehicles")]
        public string? _Vehicles { get; set; }
        [NotMapped]
        [DisplayName("Starships Array")]
        public string[]? Starships { get; set; }   //comma separated array
        [DisplayName("Starships")]
        public string? _Starships { get; set; }
    }
}
