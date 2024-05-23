using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_StarWarsAPI_MVC.Models.Swapi
{
    public class Vehicle : BaseEntity
    {
        [DisplayName("Model")]
        public string Model { get; set; }
        [DisplayName("Vehicle Class")]
        public string Vehicle_Class { get; set; }
        public string Manufacturer { get; set; }
        public string Length { get; set; }
        [DisplayName("Cost")]
        public string Cost_In_Credits { get; set; }
        [DisplayName("Crew Capacity")]
        public string Crew { get; set; }
        [DisplayName("Passenger Capacity")]
        public string Passengers { get; set; }
        [DisplayName("Max Atmo Speed")]
        public string Max_Atmosphering_Speed { get; set; }
        [DisplayName("Cargo Capacity")]
        public string Cargo_Capacity { get; set; }
        public string Consumables { get; set; }
        [NotMapped]
        [DisplayName("Pilots Array")]
        public string[]? Pilots { get; set; }   //comma separated array
        [DisplayName("Pilots")]
        public string? _Pilots { get; set; }
    }
}