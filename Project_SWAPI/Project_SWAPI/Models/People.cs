using System;

namespace Project_SWAPI.Models
{
    public class People
    {
        public int Id { get; set; }
        public string name { get; set; }
		public int height { get; set; }
		public int mass { get; set; }
		public string hair_color { get; set; }
		public string skin_color { get; set; }
		public string eye_color { get; set; }
		public string birth_year { get; set; }
		public string gender { get; set; }
		public string homeworld { get; set; }
		public string[] films { get; set; }
		publci string[] species { get; set; }
		public string[] vehicles { get; set; }
		public string[] starships { get; set; }
		public string created { get; set; }
		public string edited { get; set; }
		public string url { get; set; }
    }
}
