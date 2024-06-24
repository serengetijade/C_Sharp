namespace Project_StarWarsAPI_MVC.Models.SwapiResponses
{
    public class SpeciesResponse : BaseEntityResponse
    {
        public string Average_Height { get; set; }
        public string Average_Lifespan { get; set; }
        public string Classification { get; set; }
        public string Designation { get; set; }
        public string Eye_Colors { get; set; }
        public string Hair_Colors { get; set; }
        public string? Homeworld { get; set; }
        public string Language { get; set; }
        public string[]? People { get; set; }
        public string Skin_Colors { get; set; }
    }
}