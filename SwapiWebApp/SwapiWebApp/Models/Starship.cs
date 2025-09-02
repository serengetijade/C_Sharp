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
        public string? Cost_In_Credits { get; set; }
        [DisplayName("Crew Capacity")]
        public string? Crew { get; set; }
        [DisplayName("Hyperdrive Rating")]
        public string? Hyperdrive_Rating { get; set; }
        public byte[]? Image { get; set; }
        [NotMapped]
        [Display(Name = "Image File")]
        public IFormFile? imageFile { get; set; }
        public string? Length { get; set; }
        public string? Manufacturer { get; set; }
        [DisplayName("Max Atmo Speed")]
        public string? Max_Atmosphering_Speed { get; set; }
        public string? MGLT { get; set; }
        public string? Model { get; set; }
        [DisplayName("Passenger Capacity")]
        public string? Passengers { get; set; }
        [NotMapped]
        public string[]? Pilots { get; set; }
        [DisplayName("Pilots")]
        public List<People> PilotsList { get; set; } = new List<People>();
        [DisplayName("Class")]
        public string? Starship_Class { get; set; }

        //DateTime example: 
        //[JsonProperty("birthday")]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        //public DateTime birthday { get; set; }
    }
}