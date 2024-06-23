using System.ComponentModel;

namespace Project_StarWarsAPI_MVC.Models.Swapi
{
    public class Film : BaseEntity
    {
        public string[]? Characters { get; set; }
        public string Director { get; set; }
        [DisplayName("Episode ID")]
        public string Episode_Id { get; set; }
        [DisplayName("Opening Crawl")]
        public string Opening_Crawl { get; set; }
        public string[]? Planets { get; set; }
        public string Producer { get; set; }
        [DisplayName("Release Date")]
        public string Release_Date { get; set; }
        public string[]? Species { get; set; }
        public string[]? Starships { get; set; }
        public string Title { get; set; }
        public string[]? Vehicles { get; set; }           
    }
}