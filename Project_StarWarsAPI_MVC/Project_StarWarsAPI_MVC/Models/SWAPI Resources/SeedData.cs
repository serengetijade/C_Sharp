using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Project_StarWarsAPI_MVC.Data;
using Project_StarWarsAPI_MVC.Models.Content;
using System.Security.Cryptography;
using System.Text;

namespace Project_StarWarsAPI_MVC.Models.SWAPI_Resources
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
                    SeedData.GetRandomRecord(serviceProvider);
                    return;
                }

                //Create an "empty" record that will serve to hold random data later, this data is then used on the landing page. 
                Starship randomRecord = new Starship() { name = "initial", model = "initial", manufacturer = "initial", cost_in_credits = "initial", length = "initial", max_atmosphering_speed = "initial", crew = "initial", passengers = "initial", cargo_capacity = "initial", consumables = "initial", hyperdrive_rating = "initial", starship_class = "initial", _pilots = "initial", _films = "initial", created = "initial", edited = "initial", url = "initial", MGLT="initial"};
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
                            var result = JsonConvert.DeserializeObject<ApiResult>(jsonResponse);    //Parse API 'results':

                            switch (resource)
                            {
                                case "starships":
                                    Console.WriteLine("Starships:");
                                    foreach (JObject r in result.results)
                                    {
                                        Starship record = (Starship)r.ToObject(typeof(Starship));   //Result: each object is converted to Starship
                                        record._films = SeedData.ArrayToStringConverter(record.films);
                                        record._pilots = SeedData.ArrayToStringConverter(record.pilots);
                                        context.Starship.Add(record);
                                        Console.WriteLine(record.name + " was added to database."); //Result: Starship's name
                                        //Console.WriteLine(r.ToString());                          //Result: All the starship details
                                        //Console.WriteLine(record.GetType().Name);                 //Result: Starship 
                                    }
                                    break;
                                case "films":
                                    Console.WriteLine("\nFilms:");
                                    foreach (JObject r in result.results)
                                    {
                                        Film record = (Film)r.ToObject(typeof(Film));
                                        record._species = SeedData.ArrayToStringConverter(record.species);
                                        record._starships = SeedData.ArrayToStringConverter(record.starships);
                                        record._vehicles = SeedData.ArrayToStringConverter(record.vehicles);
                                        record._characters = SeedData.ArrayToStringConverter(record.characters);
                                        record._planets = SeedData.ArrayToStringConverter(record.planets);
                                        context.Films.Add(record);
                                        Console.WriteLine(record.title + " was added to database.");
                                    }
                                    break;
                                case "people":
                                    Console.WriteLine("\nPeople:");
                                    foreach (JObject r in result.results)
                                    {
                                        People record = (People)r.ToObject(typeof(People));
                                        record._films = SeedData.ArrayToStringConverter(record.films);
                                        record._species = SeedData.ArrayToStringConverter(record.species);
                                        record._vehicles = SeedData.ArrayToStringConverter(record.vehicles);
                                        record._starships = SeedData.ArrayToStringConverter(record.starships);
                                        context.People.Add(record);
                                        Console.WriteLine(record.name + " was added to database.");
                                    }
                                    break;
                                case "planets":
                                    Console.WriteLine("\nPlanets:");
                                    foreach (JObject r in result.results)
                                    {
                                        Planet record = (Planet)r.ToObject(typeof(Planet));
                                        record._residents = SeedData.ArrayToStringConverter(record.residents);
                                        record._films = SeedData.ArrayToStringConverter(record.films);
                                        context.Planets.Add(record);
                                        Console.WriteLine(record.name + " was added to database.");
                                    }
                                    break;
                                case "species":
                                    Console.WriteLine("\nSpecies:");
                                    foreach (JObject r in result.results)
                                    {
                                        Species record = (Species)r.ToObject(typeof(Species));
                                        record._films = SeedData.ArrayToStringConverter(record.films);
                                        record._people = SeedData.ArrayToStringConverter(record.people);
                                        context.Species.Add(record);
                                        Console.WriteLine(record.name + " was added to database.");
                                    }
                                    break;
                                case "vehicles":
                                    Console.WriteLine("\nVehicles:");
                                    foreach (JObject r in result.results)
                                    {
                                        Vehicle record = (Vehicle)r.ToObject(typeof(Vehicle));
                                        record._films = SeedData.ArrayToStringConverter(record.films);
                                        record._pilots = SeedData.ArrayToStringConverter(record.pilots);
                                        context.Vehicle.Add(record);
                                        Console.WriteLine(record.name + " was added to database.");
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
                SeedData.GetRandomRecord(serviceProvider);
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
            string[] urlArray = record.Split(", ");
            return urlArray;
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
                record.name = randomRecord.name;
                record.manufacturer = randomRecord.manufacturer;
                record.model = randomRecord.model;
                record.cost_in_credits = randomRecord.cost_in_credits;
                record.length = randomRecord.length;
                record.MGLT = randomRecord.MGLT;
                record._pilots = randomRecord._pilots;
                record.max_atmosphering_speed = randomRecord.max_atmosphering_speed;
                record.crew = randomRecord.crew;
                record.passengers = randomRecord.passengers;
                record.cargo_capacity = randomRecord.cargo_capacity;
                record.consumables = randomRecord.consumables;
                record._films = randomRecord._films;
                record.created = randomRecord.created;
                record.edited = randomRecord.edited;
                record.url = randomRecord.url;
                record.starship_class = randomRecord.starship_class;
                record.hyperdrive_rating = randomRecord.hyperdrive_rating;
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

        //Unfinished: Method to get data 
        //public static async Task<JObject[]> GetData(string resource, HttpClient httpClient)
        //{
        //    {
        //        JObject[] apiResult = new JObject[] { };
        //        Console.WriteLine("Testrun has been called");
        //        string url = "https://swapi.dev/api/" + resource + "/";
        //        try
        //        {
        //            var response = await httpClient.GetAsync(url);                          //GET request to the API
        //            string jsonResponse = await response.Content.ReadAsStringAsync();       //Read the string from the response '.Content' //ReadASStringAsync is a method that reads asyncrhonously without holding up the main thread. 
        //            var result = JsonConvert.DeserializeObject<ApiResult>(jsonResponse);    //Parse API 'results':

        //            foreach (JObject r in result.results)
        //            {
        //                JObject resultss = (JObject)r.ToObject(typeof(JObject));
        //                apiResult.Append(resultss);            
        //            }
        //            return apiResult;
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(ex.Message);
        //            Console.WriteLine($"API call to {resource} failed.");
        //            var result = new ApiResult();
        //            return apiResult;
        //        }
        //    }
        //}
    }
}

