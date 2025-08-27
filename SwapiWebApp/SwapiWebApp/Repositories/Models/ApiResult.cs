using System.Text.Json.Nodes;

namespace SwapiWebApp.Repositories.Models
{
    public class ApiResult
    {
        public string Count { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }
        public List<JsonObject> Results { get; set; }
    }
}