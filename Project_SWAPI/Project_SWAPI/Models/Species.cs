using System;

namespace Project_SWAPI.Models
{
    public class Species
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string classification { get; set; }
        public string designation { get; set; }
        public decimal average_height { get; set; }
        public int average_lifespan { get; set; }
        public string eye_colors { get; set; }
        public string hair_colors { get; set; }
        public string skin_colors { get; set; }
        public string language { get; set; }
        public string homeworld { get; set; }
        public string[] people { get; set; }
        public string[] films { get; set; }
        public string created { get; set; }
        public string edited { get; set; }
        public string url { get; set; }
    }
}
