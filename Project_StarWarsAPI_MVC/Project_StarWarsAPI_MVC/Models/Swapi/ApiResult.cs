using System.ComponentModel.DataAnnotations.Schema;

namespace Project_StarWarsAPI_MVC.Models.Swapi
{
    [NotMapped]
    public class ApiResult
    {
        public string count { get; set; }
        public string? next { get; set; }
        public string? previous { get; set; }
        public List<object>? results { get; set; }
    }
}
