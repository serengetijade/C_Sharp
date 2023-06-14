using System.Diagnostics.Metrics;
using System.Reflection;
using System.Security.Cryptography.Xml;
using System.Xml.Linq;
using System;

namespace Project_SWAPI.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string model { get; set; }
        public string vehicle_class { get; set; }
        public string manufacturer { get; set;}
        public decimal length { get; set;}
        public int cost_in_credits { get; set;}
        public int crew { get; set;}
        public int passengers { get; set;}
        public int max_atmosphering_speed { get; set;}
        public int cargo_capacity { get; set;}
        public string consumables { get; set;}
        public string[] films { get; set;}
        public string[] pilots { get; set;}
        public string url { get; set;}
        public string created { get; set; }
        public string edited { get; set; }
    }
}
