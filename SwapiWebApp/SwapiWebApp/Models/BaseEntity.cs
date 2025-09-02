using System.ComponentModel.DataAnnotations.Schema;

namespace Project_StarWarsAPI_MVC.Models.Swapi
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public string? Created { get; set; }
        public string? Edited { get; set; }
        [NotMapped]
        public string[]? Films { get; set; }
        public List<Film> FilmsList { get; set; } = new List<Film>();
        public string? Name { get; set; }
        public string? Url { get; set; }
    }
}