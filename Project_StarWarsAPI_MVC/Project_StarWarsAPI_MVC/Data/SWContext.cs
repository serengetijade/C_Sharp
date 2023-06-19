using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project_StarWarsAPI_MVC.Models.Content;
using Project_StarWarsAPI_MVC.Models.SWAPI_Resources;

namespace Project_StarWarsAPI_MVC.Data
{
    public class SWContext : DbContext
    {
        //Constructor
        public SWContext (DbContextOptions<SWContext> options)
            : base(options){}

        //Define a DbSet to instantiate each table 
        public DbSet<Starship> Starship { get; set; } = default!;
        public DbSet<Film> Films { get; set; }
        public DbSet<People> People { get; set; }
        public DbSet<Planet> Planets { get; set; }
        public DbSet<Species> Species { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }
    }
}
