using System.ComponentModel;

namespace Project_StarWarsAPI_MVC.Models.ViewModels
{
    public class VehicleViewModel : BaseEntityViewModel
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
        public List<string>? Pilots { get; set; }
        [DisplayName("Vehicle Class")]
        public string Vehicle_Class { get; set; }
    }
}