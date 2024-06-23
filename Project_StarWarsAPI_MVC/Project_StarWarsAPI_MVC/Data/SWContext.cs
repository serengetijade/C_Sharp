using Microsoft.EntityFrameworkCore;
using Project_StarWarsAPI_MVC.Models.Swapi;

namespace Project_StarWarsAPI_MVC.Data
{
    public class SWContext : DbContext
    {
        public SWContext (DbContextOptions<SWContext> options)
            : base(options){}

        public DbSet<Film> Films { get; set; }
        public DbSet<People> People { get; set; }
        public DbSet<Planet> Planets { get; set; }
        public DbSet<Species> Species { get; set; }
        public DbSet<Starship> Starship { get; set; } = default!;
        public DbSet<Vehicle> Vehicle { get; set; }
    }
}