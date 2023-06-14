namespace Project_SWAPI.Models
{
    public class Planet
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int diameter { get; set; }
        public int rotation_period { get; set; }
        public int orbital_period { get; set; }
        public int gravity { get; set; }
        public int population { get; set; }
        public string climate { get; set; }
        public string terrain { get; set; }
        public int surface_water { get; set; }
        public string[] residents { get; set; }
        public string[] films { get; set; }
        public string url { get; set; }
        public string created { get; set; }
        public string edited { get; set; }
    }
}
