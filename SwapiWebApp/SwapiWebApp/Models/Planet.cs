using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_StarWarsAPI_MVC.Models.Swapi
{
    public class Planet : BaseEntity
    {
        public string Diameter { get; set; }
        [DisplayName("Rotation Period")]
        public string Rotation_Period { get; set; }
        [DisplayName("Orbital Period")]
        public string Orbital_Period { get; set; }
        public string Gravity { get; set; }
        public string Population { get; set; }
        public string Climate { get; set; }
        public string Terrain { get; set; }
        [DisplayName("Surface Water")]
        public string Surface_Water { get; set; }
        [NotMapped]
        public string[]? Residents { get; set; }  //comma separated array
        [DisplayName("Residents")]
        public List<People> ResidentsList { get; set; }
    }
}