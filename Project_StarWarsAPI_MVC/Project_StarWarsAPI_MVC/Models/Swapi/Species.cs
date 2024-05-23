using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_StarWarsAPI_MVC.Models.Swapi
{
    public class Species : BaseEntity
    {
        public string Classification { get; set; }
        public string Designation { get; set; }
        [DisplayName("Avg Height")]
        public string Average_Height { get; set; }
        [DisplayName("Avg Lifespan")]
        public string Average_Lifespan { get; set; }
        [DisplayName("EyeColor")]
        public string Eye_Colors { get; set; }
        [DisplayName("Hair Colors")]
        public string Hair_Colors { get; set; }
        [DisplayName("Skin Colors")]
        public string Skin_Colors { get; set; }
        [DisplayName("Language")]
        public string Language { get; set; }
        [DisplayName("Homeworld")]
        public string? Homeworld { get; set; }
        [NotMapped]
        [DisplayName("People Array")]
        public string[]? People { get; set; }   //comma separated array
        [DisplayName("People")]
        public string? _People { get; set; }
    }
}
