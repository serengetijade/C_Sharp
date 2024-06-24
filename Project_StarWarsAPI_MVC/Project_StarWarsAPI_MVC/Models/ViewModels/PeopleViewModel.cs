using System.ComponentModel;

namespace Project_StarWarsAPI_MVC.Models.Swapi
{
    public class PeopleViewModel : BaseEntity
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
        public List<string>? Species { get; set; }
        public List<string>? Starships { get; set; }
        public List<string>? Vehicles { get; set; }
    }
}
