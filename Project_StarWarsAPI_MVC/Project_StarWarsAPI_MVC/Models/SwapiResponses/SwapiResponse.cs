﻿using Newtonsoft.Json.Linq;

namespace Project_StarWarsAPI_MVC.Models.SwapiResponses
{
    public class SwapiResponse
    {
        public int Count{ get; set; }
        public string? Next { get; set; }
        public string? Previous { get; set; }
        public List<JObject>? Results { get; set; }
    }
}