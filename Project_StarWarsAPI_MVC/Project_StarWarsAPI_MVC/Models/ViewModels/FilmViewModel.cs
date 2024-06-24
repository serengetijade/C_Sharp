using System.ComponentModel;

namespace Project_StarWarsAPI_MVC.Models.ViewModels
{
    public class FilmViewModel : BaseEntityViewModel
    {
        public List<string>? Characters { get; set; }
        public string Director { get; set; }
        [DisplayName("Episode ID")]
        public string Episode_Id { get; set; }
        [DisplayName("Opening Crawl")]
        public string Opening_Crawl { get; set; }
        public List<string>? Planets { get; set; }
        public string Producer { get; set; }
        [DisplayName("Release Date")]
        public string Release_Date { get; set; }
        public List<string>? Species { get; set; }                  
        public List<string>? Starships { get; set; }
        public string Title { get; set; }
        public List<string>? Vehicles { get; set; }           
    }
}