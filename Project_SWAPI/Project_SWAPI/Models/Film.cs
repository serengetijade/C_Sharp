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
        public string[] species { get; set; }
        public string[] starships { get; set; }
        public string[] vehicles { get; set; }
        public string[] characters { get; set;}
        public string[] planets { get; set; }
    }
}
