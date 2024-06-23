using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Project_StarWarsAPI_MVC.Models.Swapi
{
    public class Starship : BaseEntity
    {
        public byte[]? Image { get; set; }
        [NotMapped]
        [Display(Name = "Image File")]
        public IFormFile? imageFile { get; set; }
        public string Model { get; set; }
        public string? Manufacturer { get; set; }
        [DisplayName("Cost")]
        public string Cost_In_Credits { get; set; }
        public string? Length { get; set; }
        [DisplayName("Max Atmo Speed")]
        public string? Max_Atmosphering_Speed { get; set; }
        [DisplayName("Crew Capacity")]
        public string? Crew { get; set; }
        [DisplayName("Passenger Capacity")]
        public string? Passengers { get; set; }
        [DisplayName("Cargo Capacity")]
        public string? Cargo_Capacity { get; set; }
        public string? Consumables { get; set; }
        [DisplayName("Hyperdrive Rating")]
        public string? Hyperdrive_Rating { get; set; }
        public string? MGLT { get; set; }
        [DisplayName("Class")]
        public string? Starship_Class { get; set; }
        [NotMapped]
        [DisplayName("Pilots Array")]
        public string[]? Pilots { get; set; }
        [DisplayName("Pilots")]
        public string? _Pilots { get; set; }

        //DateTime example: 
        //[JsonProperty("birthday")]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        //public DateTime birthday { get; set; }
    }
}