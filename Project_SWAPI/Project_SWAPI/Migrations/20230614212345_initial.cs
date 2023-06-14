using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_SWAPI.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    episode_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    opening_crawl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    director = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    producer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    release_date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    species = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    starships = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    vehicles = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    characters = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    planets = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    height = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hair_color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    skin_color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    eye_color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    birth_year = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    homeworld = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    films = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    species = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    vehicles = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    starships = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    created = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    edited = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Planets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    diameter = table.Column<int>(type: "int", nullable: false),
                    rotation_period = table.Column<int>(type: "int", nullable: false),
                    orbital_period = table.Column<int>(type: "int", nullable: false),
                    gravity = table.Column<int>(type: "int", nullable: false),
                    population = table.Column<int>(type: "int", nullable: false),
                    climate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    terrain = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    surface_water = table.Column<int>(type: "int", nullable: false),
                    residents = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    films = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    created = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    edited = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Species",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    classification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    designation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    average_height = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    average_lifespan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    eye_colors = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hair_colors = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    skin_colors = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    language = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    homeworld = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    people = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    films = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    created = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    edited = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Species", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Starships",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cost_in_credits = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    length = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    max_atmosphering_speed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    crew = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    passengers = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cargo_capacity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    consumables = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hyperdrive_rating = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MGLT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    starship_class = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pilots = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    films = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    created = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    edited = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Starships", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    vehicle_class = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    length = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cost_in_credits = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    crew = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    passengers = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    max_atmosphering_speed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cargo_capacity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    consumables = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    films = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pilots = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    created = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    edited = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Films");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "Planets");

            migrationBuilder.DropTable(
                name: "Species");

            migrationBuilder.DropTable(
                name: "Starships");

            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
