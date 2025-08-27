using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_StarWarsAPI_MVC.Models.Swapi
{
    public class Vehicle : BaseEntity
    {
        [DisplayName("Cargo Capacity")]
        public string Cargo_Capacity { get; set; }
        public string Consumables { get; set; }
        [DisplayName("Cost")]
        public string Cost_In_Credits { get; set; }
        [DisplayName("Crew Capacity")]
        public string Crew { get; set; }
        public string Length { get; set; }
        public string Manufacturer { get; set; }
        [DisplayName("Max Atmo Speed")]
        public string Max_Atmosphering_Speed { get; set; }
        public string Model { get; set; }
        [DisplayName("Passenger Capacity")]
        public string Passengers { get; set; }
        [NotMapped]
        public string[] Pilots { get; set; }
        public List<People> PilotsList { get; set; }
		[DisplayName("Vehicle Class")]
        public string Vehicle_Class { get; set; }
    }
}