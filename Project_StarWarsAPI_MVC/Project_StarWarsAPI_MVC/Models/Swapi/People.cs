using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_StarWarsAPI_MVC.Models.Swapi
{
    public class People : BaseEntity
    {
        [DisplayName("Birth Year")]
        public string Birth_Year { get; set; }
        [DisplayName("Eye Color")]
        public string Eye_Color { get; set; }
        public string Gender { get; set; }
        [DisplayName("Hair Color")]
        public string Hair_Color { get; set; }
        public string Height { get; set; }
        public string Homeworld { get; set; }
        public string Mass { get; set; }
        [DisplayName("Skin Color")]
        public string Skin_Color { get; set; }
        public string[]? Species { get; set; }
        public string[]? Starships { get; set; }
        public string[]? Vehicles { get; set; }
    }
}
