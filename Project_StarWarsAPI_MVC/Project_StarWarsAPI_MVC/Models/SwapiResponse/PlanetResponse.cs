namespace Project_StarWarsAPI_MVC.Models.Swapi
{
    public class PlanetResponse : BaseEntity
    {
        public string Diameter { get; set; }
        public string Climate { get; set; }
        public string Gravity { get; set; }
        public string Orbital_Period { get; set; }
        public string Population { get; set; }
        public string[]? Residents { get; set; }  //comma separated array
        public string Rotation_Period { get; set; }
        public string Surface_Water { get; set; }
        public string Terrain { get; set; }
    }
}