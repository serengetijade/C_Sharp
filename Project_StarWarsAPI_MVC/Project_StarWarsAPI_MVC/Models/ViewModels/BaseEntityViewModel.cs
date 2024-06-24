using System.ComponentModel.DataAnnotations;

namespace Project_StarWarsAPI_MVC.Models.Swapi
{
    public class BaseEntityViewModel
    {
        [Key]
        public int Id { get; set; }
        public string Created { get; set; }
        public string Edited { get; set; }
        public string[]? Films { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }
}