using System.ComponentModel.DataAnnotations.Schema;

namespace Project_StarWarsAPI_MVC.Models.SwapiEntities
{
    public class Starship : BaseEntity
    {
        public string? Cargo_Capacity { get; set; }
        public string? Consumables { get; set; }
        public string? Cost_In_Credits { get; set; }
        public string? Crew { get; set; }
        public string? Hyperdrive_Rating { get; set; }
        public byte[]? Image { get; set; }
        [NotMapped]
        public IFormFile? ImageFile { get; set; }
        public string? Length { get; set; }
        public string? Max_Atmosphering_Speed { get; set; }
        public string? Manufacturer { get; set; }
        public string? MGLT { get; set; }
        public string? Model { get; set; }
        public string? Passengers { get; set; }
        public string? Pilots { get; set; }
        public string? Starship_Class { get; set; }
    }
}