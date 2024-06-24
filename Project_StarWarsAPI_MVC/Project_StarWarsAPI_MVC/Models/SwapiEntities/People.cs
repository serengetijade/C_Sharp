using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_StarWarsAPI_MVC.Models.SwapiEntities
{
    public class People : BaseEntity
    {
        public string Birth_Year { get; set; }
        public string Eye_Color { get; set; }
        public string Gender { get; set; }
        public string Hair_Color { get; set; }
        public string Height { get; set; }
        public string Homeworld { get; set; }
        public string Mass { get; set; }
        public string Skin_Color { get; set; }
        public string Species { get; set; }
        public string Starships { get; set; }
        public string Vehicles { get; set; }
    }
}
