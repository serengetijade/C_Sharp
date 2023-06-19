using Newtonsoft.Json;
using Project_StarWarsAPI_MVC.Models.Content;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_StarWarsAPI_MVC.Models.SWAPI_Resources
{
    public class Vehicle
    {
        public int Id { get; set; }
        [DisplayName("Name")]
        public string name { get; set; }
        [DisplayName("Model")]
        public string model { get; set; }
        [DisplayName("Vehicle Class")]
        public string vehicle_class { get; set; }
        [DisplayName("Manufacturer")]
        public string manufacturer { get; set; }
        [DisplayName("Length")]
        public string length { get; set; }
        [DisplayName("Cost")]
        public string cost_in_credits { get; set; }
        [DisplayName("Crew Capacity")]
        public string crew { get; set; }
        [DisplayName("Passenger Capacity")]
        public string passengers { get; set; }
        [DisplayName("Max Atmo Speed")]
        public string max_atmosphering_speed { get; set; }
        [DisplayName("Cargo Capacity")]
        public string cargo_capacity { get; set; }
        [DisplayName("Consumables")]
        public string consumables { get; set; }
        [NotMapped]
        [DisplayName("Films Array")]
        public string[]? films { get; set; }    //comma separated array
        [DisplayName("Films")]
        public string? _films { get; set; }
        [NotMapped]
        [DisplayName("Pilots Array")]
        public string[]? pilots { get; set; }   //comma separated array
        [DisplayName("Pilots")]
        public string? _pilots { get; set; }
        [DisplayName("URL")]
        public string url { get; set; }
        [DisplayName("Created")]
        public string created { get; set; }
        [DisplayName("Edited")]
        public string edited { get; set; }
    }
}
