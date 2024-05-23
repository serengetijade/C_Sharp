using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_StarWarsAPI_MVC.Models.Swapi
{
    public class Film
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [DisplayName("Episode ID")]
        public string Episode_Id { get; set; }
        [DisplayName("Opening Crawl")]
        public string Opening_Crawl { get; set; }
        public string Director { get; set; }
        public string Producer { get; set; }
        [DisplayName("Release Date")]
        public string Release_Date { get; set; }
        [NotMapped]
        [DisplayName("Species Array")]
        public string[]? Species { get; set; }
        [DisplayName("Species")]
        public string? _Species { get; set; }
        [NotMapped]
        [DisplayName("Starships Array")]
        public string[]? Starships { get; set; }
        [DisplayName("Starships")]
        public string? _Starships {get; set; }
        [NotMapped]
        [DisplayName("Vechicles Array")]
        public string[]? Vehicles { get; set; }
        [DisplayName("Vehicles")]
        public string? _Vehicles { get; set; }
        [NotMapped]
        [DisplayName("Characters Array")]
        public string[]? Characters { get; set; }
        [DisplayName("Characters")]
        public string? _Characters { get; set; }
        [NotMapped]
        [DisplayName("Planets Array")]
        public string[]? Planets { get; set; }
        [DisplayName("Planets")]
        public string? _Planets { get; set; }
    }
}