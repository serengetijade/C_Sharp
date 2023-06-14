using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_SWAPI.Models
{
    /// <summary>
    /// Database Context: create the tables in the database. 
    /// The connection string for the db is defined in appsettings.json. 
    /// </summary>
    public class SWAPIContext : DbContext
    {
        public SWAPIContext(DbContextOptions options) : base(options) { }

        public DbSet<Film> Films { get; set; }
        public DbSet<People> People { get; set; }
        public DbSet<Planet> Planets { get; set; }
        public DbSet<Species> Species { get; set; }
        public DbSet<Starship> Starships { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
    }
}
