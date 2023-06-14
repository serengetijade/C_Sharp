using System.Diagnostics.Metrics;
using System.IO;
using System;

namespace Project_SWAPI.Models
{
    public class Film
    {
        public int Id { get; set; }
        public string title { get; set; }
        public string episode_id { get; set; }
        public string opening_crawl { get; set; }
        public string director { get; set; }
        public string producer { get; set; }
        public string release_date { get; set; }
        public string species { get; set; }    //comma separated array
        public string starships { get; set; }  //comma separated array
        public string vehicles { get; set; }   //comma separated array
        public string characters { get; set; } //comma separated array
        public string planets { get; set; }    //comma separated array
    }
}
