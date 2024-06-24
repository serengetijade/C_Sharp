using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Project_StarWarsAPI_MVC.Models.Swapi;
using Project_StarWarsAPI_MVC.Models.SwapiResponse;
using System.Security.Cryptography;
using System.Text;

namespace Project_StarWarsAPI_MVC.Data
{
    /// <summary>
    /// Seed the db with data from the Star Wars API
    /// </summary>
    public class SeedData
    {
        public static async void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SWContext(serviceProvider.GetRequiredService<DbContextOptions<SWContext>>()))
            {
                //If the Db has records, do nothing: 
                if (context.Starship.Any())
                {
                    GetRandomRecord(serviceProvider);
                    return;
                }

                //Create an "empty" record that will serve to hold random data later, this data is then used on the landing page. 
                Starship randomRecord = new Starship() { Image = { }, Name = "initial", Model = "initial", Manufacturer = "initial", Cost_In_Credits = "initial", Length = "initial", Max_Atmosphering_Speed = "initial", Crew = "initial", Passengers = "initial", Cargo_Capacity = "initial", Consumables = "initial", Hyperdrive_Rating = "initial", Starship_Class = "initial", Pilots = new string[] { "initial1", "initial2" } , Films = new string[] { "initial1", "initial2" }, Created = "initial", Edited = "initial", Url = "initial", MGLT = "initial" };
                context.Starship.Add(randomRecord);

                using (HttpClient httpClient = new HttpClient())
                {
                    httpClient.BaseAddress = new Uri("https://swapi.dev/api/");

                    //Seed the Db: 
                    List<string> resources = new List<string>() { "starships", "films", "people", "planets", "species", "vehicles" };
                    foreach (string resource in resources)
                    {
                        try
                        {
                            //Get data from the API:
                            var response = await httpClient.GetAsync(resource);                     //GET request to the API: add the provided string to the base url address
                            string jsonResponse = await response.Content.ReadAsStringAsync();       //Read the string from the response '.Content' //ReadASStringAsync is a method that reads asyncrhonously without holding up the main thread. 
                            var result = JsonConvert.DeserializeObject<Response>(jsonResponse);    //Parse API 'results':

                            switch (resource)
                            {
                                case "starships":
                                    Console.WriteLine("Starships:");
                                    foreach (JObject r in result.Results)
                                    {
                                        Starship record = (Starship)r.ToObject(typeof(Starship));   //Result: each object is converted to Starship
                                       
                                        context.Starship.Add(record);
                                        Console.WriteLine(record.Name + " was added to database."); //Result: Starship's name
                                        //Console.WriteLine(r.ToString());                          //Result: All the starship details
                                        //Console.WriteLine(record.GetType().Name);                 //Result: Starship 
                                    }
                                    break;
                                case "films":
                                    Console.WriteLine("\nFilms:");
                                    foreach (JObject r in result.Results)
                                    {
                                        Film record = (Film)r.ToObject(typeof(Film));

                                        context.Films.Add(record);
                                        Console.WriteLine(record.Title + " was added to database.");
                                    }
                                    break;
                                case "people":
                                    Console.WriteLine("\nPeople:");
                                    foreach (JObject r in result.Results)
                                    {
                                        People record = (People)r.ToObject(typeof(People));

                                        context.People.Add(record);
                                        Console.WriteLine(record.Name + " was added to database.");
                                    }
                                    break;
                                case "planets":
                                    Console.WriteLine("\nPlanets:");
                                    foreach (JObject r in result.Results)
                                    {
                                        Planet record = (Planet)r.ToObject(typeof(Planet));

                                        context.Planets.Add(record);
                                        Console.WriteLine(record.Name + " was added to database.");
                                    }
                                    break;
                                case "species":
                                    Console.WriteLine("\nSpecies:");
                                    foreach (JObject r in result.Results)
                                    {
                                        Species record = (Species)r.ToObject(typeof(Species));

                                        context.Species.Add(record);
                                        Console.WriteLine(record.Name + " was added to database.");
                                    }
                                    break;
                                case "vehicles":
                                    Console.WriteLine("\nVehicles:");
                                    foreach (JObject r in result.Results)
                                    {
                                        Vehicle record = (Vehicle)r.ToObject(typeof(Vehicle));

                                        context.Vehicle.Add(record);
                                        Console.WriteLine(record.Name + " was added to database.");
                                    }
                                    break;
                            }
                        }

                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        finally
                        {
                        }
                    }
                    httpClient.Dispose();
                }
                context.SaveChanges();
                GetRandomRecord(serviceProvider);
                context.Dispose();
            }
        }

        /// <summary>
        /// Convert API results (recieved as json string arrays) into strings. 
        /// The results are string arrays, and not key-value-pairs, so StringBuilder is used to convert into strings. 
        /// JsonConver.Deserialize\<string\>(results) did not work.  
        /// </summary>
        /// <param name="results"></param>
        /// <returns></returns>
        public static string ArrayToStringConverter(string[]? results)
        {
            StringBuilder result = new StringBuilder();
            int counter = 0;
            foreach (string item in results)
            {
                counter++;
                if (counter < results.Length)
                {
                    result.Append(item + ", ");
                }
                else
                {
                    result.Append(item);
                }
            }
            return result.ToString();
        }

        /// <summary>
        /// Convert string db record into individual results.
        /// </summary>
        /// <param name="record"></param>
        /// <returns>Array of string objects.</returns>
        public static string[] StringToArray(string record)
        {
            if (record != null)
            {
                string[] urlArray = record.Split(", ");
                return urlArray;
            }
            else
            {
                string[] urlArray = null;
                return urlArray;
            }
        }

        /// <summary>
        ///Perpetuate a random database record by adding it to the database at the first index position. 
        ///Requires that an "initial"/empty record be created at startup and placed in the SeedData method:
        ///Starship randomRecord = new Starship() { name = "initial", model = "initial", manufacturer = "initial", cost_in_credits = "initial", length = "initial", max_atmosphering_speed = "initial", crew = "initial", passengers = "initial", cargo_capacity = "initial", consumables = "initial", hyperdrive_rating = "initial", starship_class = "initial", _pilots = "initial", _films = "initial", created = "initial", edited = "initial", url = "initial", MGLT="initial"};
        ///context.Starship.Add(randomRecord);
        /// </summary>
        //public static async Task<Starship> GetRandomRecord(IServiceProvider serviceProvider)  //This method sytnax returns a random starship via the statment: return randomRecord;
        public static void GetRandomRecord(IServiceProvider serviceProvider)
        {
            using (var context = new SWContext(serviceProvider.GetRequiredService<DbContextOptions<SWContext>>()))
            {
                //Get a random record from the db:
                List<int> idNumbers = new List<int>();                          //Create an empty list to hold Id numbers.
                int firstItem = context.Starship.First().Id;                    //Find the lowest Id number in the db.
                foreach (Starship item in context.Starship)                     //Get all Id numbers into idNumbers list.
                {                                                               //...But...
                    if (item.Id != firstItem)                                   //Exclude the "initial" record (created above in Seed method).
                    {
                        idNumbers.Add(item.Id);
                    }
                }
                int itemCount = idNumbers.Count();                              //Count number of list entries.
                int randomIndex = RandomNumberGenerator.GetInt32(itemCount);    //Get a random index number from the list of Id numbers (returns a number between -1 and given upper limit (itemCount), but not including it)
                int randomId = idNumbers[randomIndex];                          //Set the value from the idNumbers list using the randomIndex number

                //Save the randomRecord to the database as a permanent entry:
                Starship randomRecord = context.Starship.Find(randomId);        //Find the record with matching Id from the list
                Starship record = context.Starship.Find(firstItem);
                record.Image = randomRecord.Image;
                record.Name = randomRecord.Name;
                record.Manufacturer = randomRecord.Manufacturer;
                record.Model = randomRecord.Model;
                record.Cost_In_Credits = randomRecord.Cost_In_Credits;
                record.Length = randomRecord.Length;
                record.MGLT = randomRecord.MGLT;
                record.Pilots = randomRecord.Pilots;
                record.Max_Atmosphering_Speed = randomRecord.Max_Atmosphering_Speed;
                record.Crew = randomRecord.Crew;
                record.Passengers = randomRecord.Passengers;
                record.Cargo_Capacity = randomRecord.Cargo_Capacity;
                record.Consumables = randomRecord.Consumables;
                record.Films = randomRecord.Films;
                record.Created = randomRecord.Created;
                record.Edited = randomRecord.Edited;
                record.Url = randomRecord.Url;
                record.Starship_Class = randomRecord.Starship_Class;
                record.Hyperdrive_Rating = randomRecord.Hyperdrive_Rating;
                context.Update(record);
                context.SaveChanges();
            }
        }

        public List<Starship> GetRandomStarshipAlternateMethod(IServiceProvider serviceProvider)
        {
            using (var context = new SWContext(serviceProvider.GetRequiredService<DbContextOptions<SWContext>>()))
            {
                return context.Starship.OrderBy(x => Guid.NewGuid()).Take(1).ToList();
            }
        }
    }
}