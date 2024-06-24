namespace Project_StarWarsAPI_MVC
{
    public class ApplicationSettings
    {
        public SwapiSettings SwapiSettings { get; set; }
    }

    public class SwapiSettings
    {
        public string ApiBaseUri { get; set; }
    }
}
