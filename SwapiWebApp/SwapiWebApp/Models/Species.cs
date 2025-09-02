using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_StarWarsAPI_MVC.Models.Swapi
{
    public class Species : BaseEntity
    {
        [DisplayName("Avg Height")]
        public string? Average_Height { get; set; }
        [DisplayName("Avg Lifespan")]
        public string? Average_Lifespan { get; set; }
        public string? Classification { get; set; }
        public string? Designation { get; set; }
        [DisplayName("EyeColor")]
        public string? Eye_Colors { get; set; }
        [DisplayName("Hair Colors")]
        public string? Hair_Colors { get; set; }
        [DisplayName("Homeworld")]
        public string? Homeworld { get; set; }
        [DisplayName("Language")]
        public string? Language { get; set; }
        [NotMapped]
        public string[]? People { get; set; }   //comma separated array
        [DisplayName("People")]
        public List<People> PeopleList { get; set; } = new List<People>();
		[DisplayName("Skin Colors")]
        public string? Skin_Colors { get; set; }
    }
}
