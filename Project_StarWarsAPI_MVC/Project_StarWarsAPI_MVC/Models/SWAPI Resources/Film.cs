using Project_StarWarsAPI_MVC.Models.Content;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_StarWarsAPI_MVC.Models.SWAPI_Resources
{
    public class Film
    {
        public int Id { get; set; }
        [DisplayName("Title")]
        public string title { get; set; }
        [DisplayName("Episode ID")]
        public string episode_id { get; set; }
        [DisplayName("Opening Crawl")]
        public string opening_crawl { get; set; }
        [DisplayName("Director")]
        public string director { get; set; }
        [DisplayName("Producer")]
        public string producer { get; set; }
        [DisplayName("Release Date")]
        public string release_date { get; set; }
        [NotMapped]
        [DisplayName("Species Array")]
        public string[]? species { get; set; }    //comma separated array
        [DisplayName("Species")]
        public string? _species { get; set; }
        [NotMapped]
        [DisplayName("Starships Array")]
        public string[]? starships { get; set; }  //comma separated array
        [DisplayName("Starships")]
        public string? _starships {get; set; }
        [NotMapped]
        [DisplayName("Vechicles Array")]
        public string[]? vehicles { get; set; }   //comma separated array
        [DisplayName("Vehicles")]
        public string? _vehicles { get; set; }
        [NotMapped]
        [DisplayName("Characters Array")]
        public string[]? characters { get; set; } //comma separated array
        [DisplayName("Characters")]
        public string? _characters { get; set; }
        [NotMapped]
        [DisplayName("Planets Array")]
        public string[]? planets { get; set; }    //comma separated array
        [DisplayName("Planets")]
        public string? _planets { get; set; }
    }
}
