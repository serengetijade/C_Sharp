using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Project_StarWarsAPI_MVC.Models.SWAPI_Resources;
using Newtonsoft.Json.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Project_StarWarsAPI_MVC.Models.Content
{
    public class Starship
    {
        public int Id { get; set; }
        [DisplayName("Ship Name")]
        public string name { get; set; }
        [DisplayName("Model")]
        public string model { get; set; }
        [DisplayName("Manufacturer")]
        public string manufacturer { get; set; }
        [DisplayName("Cost")]
        public string cost_in_credits { get; set; }
        [DisplayName("Length")]
        public string length { get; set; }
        [DisplayName("Max Atmo Speed")]
        public string max_atmosphering_speed { get; set; }
        [DisplayName("Crew Capacity")]
        public string crew { get; set; }
        [DisplayName("Passenger Capacity")]
        public string passengers { get; set; }
        [DisplayName("Cargo Capacity")]
        public string cargo_capacity { get; set; }
        [DisplayName("Consumables")]
        public string consumables { get; set; }
        [DisplayName("Hyperdrive Rating")]
        public string hyperdrive_rating { get; set; }
        public string MGLT { get; set; }
        [DisplayName("Class")]
        public string starship_class { get; set; }
        [NotMapped]
        [DisplayName("Pilots Array")]
        public string[] pilots { get; set; }
        [DisplayName("Pilots")]
        public string _pilots { get; set; }
        [NotMapped]
        [DisplayName("Film Array")]
        public string[] films { get; set; }
        [DisplayName("Films")]
        public string _films { get; set; }
        [DisplayName("Created")]
        public string created { get; set; }
        [DisplayName("Edited")]
        public string edited { get; set; }
        [DisplayName("URL")]
        public string url { get; set; }

        //DateTime example: 
        //[JsonProperty("birthday")]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        //public DateTime birthday { get; set; }

        //public string? _films
        //{
        //    get => SeedData.ArrayToStringConverter(this.films);
        //    set => value = SeedData.ArrayToStringConverter(this.films);
        //}
    }
}
