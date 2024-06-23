using Microsoft.EntityFrameworkCore;
using Project_StarWarsAPI_MVC.Models.Swapi;

namespace SwapiWebApp.Data
{
    public class SwapiContext : DbContext
    {
        public SwapiContext(DbContextOptions<SwapiContext> options)
            : base(options) { }

        public DbSet<Starship> Starship { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<People> People { get; set; }
        public DbSet<Planet> Planets { get; set; }
        public DbSet<Species> Species { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }
    }
}