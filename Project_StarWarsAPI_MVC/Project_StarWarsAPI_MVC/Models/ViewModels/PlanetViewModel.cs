using System.ComponentModel;

namespace Project_StarWarsAPI_MVC.Models.ViewModels
{
    public class PlanetViewModel : BaseEntityViewModel
    {
        public string Diameter { get; set; }
        public string Climate { get; set; }
        public string Gravity { get; set; }
        [DisplayName("Orbital Period")]
        public string Orbital_Period { get; set; }
        public string Population { get; set; }
        public List<string>? Residents { get; set; }
        [DisplayName("Rotation Period")]
        public string Rotation_Period { get; set; }
        [DisplayName("Surface Water")]
        public string Surface_Water { get; set; }
        public string Terrain { get; set; }
    }
}