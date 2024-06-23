using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Project_StarWarsAPI_MVC.Models.Swapi
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [NotMapped]
        [DisplayName("Films Array")]
        public string[]? Films { get; set; }
        [DisplayName("Films")]
        public string _Films { get; set; }
        public string Created { get; set; }
        public string Edited { get; set; }
        public string Url { get; set; }
    }
}