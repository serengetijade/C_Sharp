﻿namespace Project_StarWarsAPI_MVC.Models.SwapiEntities
{
    public class Film : BaseEntity
    {
        public string Characters { get; set; }
        public string Director { get; set; }
        public string Episode_Id { get; set; }
        public string Opening_Crawl { get; set; }
        public string Planets { get; set; }
        public string Producer { get; set; }
        public string Release_Date { get; set; }
        public string Species { get; set; }
        public string Starships { get; set; }
        public string Title { get; set; }
        public string Vehicles { get; set; }           
    }
}