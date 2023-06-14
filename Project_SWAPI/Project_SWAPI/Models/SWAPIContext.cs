using Microsoft.EntityFrameworkCore;

namespace Project_SWAPI.Models
{
    public class SWAPIContext : DbContext
    {
        public DbSet<Film> Films { get; set; }
        public DbSet<People> People { get; set; }
        public DbSet<Planet> Planets { get; set; }
        public DbSet<Species> Species { get; set; }
        public DbSet<Starship> Starships { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
    }
}
