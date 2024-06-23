using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Project_StarWarsAPI_MVC.Models.Swapi
{
    public class Starship : BaseEntity
    {
        [DisplayName("Cargo Capacity")]
        public string? Cargo_Capacity { get; set; }
        public string? Consumables { get; set; }
        [DisplayName("Cost")]
        public string Cost_In_Credits { get; set; }
        [DisplayName("Crew Capacity")]
        public string? Crew { get; set; }
        [DisplayName("Hyperdrive Rating")]
        public string? Hyperdrive_Rating { get; set; }
        public byte[]? Image { get; set; }
        [NotMapped]
        [Display(Name = "Image File")]
        public IFormFile? ImageFile { get; set; }
        public string? Length { get; set; }
        [DisplayName("Max Atmo Speed")]
        public string? Max_Atmosphering_Speed { get; set; }
        public string? Manufacturer { get; set; }
        public string? MGLT { get; set; }
        public string Model { get; set; }
        [DisplayName("Passenger Capacity")]
        public string? Passengers { get; set; }
        public string[]? Pilots { get; set; }
        [DisplayName("Class")]
        public string? Starship_Class { get; set; }
    }
}