﻿using System.ComponentModel;

namespace Project_StarWarsAPI_MVC.Models.ViewModels
{
    public class SpeciesViewModel : BaseEntityViewModel
    {
        [DisplayName("Avg Height")]
        public string Average_Height { get; set; }
        [DisplayName("Avg Lifespan")]
        public string Average_Lifespan { get; set; }
        public string Classification { get; set; }
        public string Designation { get; set; }
        [DisplayName("EyeColor")]
        public string Eye_Colors { get; set; }
        [DisplayName("Hair Colors")]
        public string Hair_Colors { get; set; }
        public string? Homeworld { get; set; }
        public string Language { get; set; }
        public List<string>? People { get; set; }  
        [DisplayName("Skin Colors")]
        public string Skin_Colors { get; set; }
    }
}