# Star Wars API Project: ASP.NET 6.0 MVC with EF Core
The Star Wars API is a publicly accessible source for data about Star Wars characters and  objects. The API delivers JSON results on films, people, planets, species, starships, and vehicles found in the Star Wars universe. This project is built using data from the API. 

## Project requirements 
A long time ago in a galaxy far, far away...
- Create a Starship model based on the https://swapi.dev/ API.
- Seed the SQL database with Starships returned from the API.
- Using Bootstrap, display the information in the most compelling way you can while making sure it is desktop and mobile friendly.
- Each time the application loads, randomly show a Starship from the database.
- Implement CRUD to manipulate the data stored in the database.

## Skill Implemented
- <b> C#: </b>Classes were added to represent each API resource. Custom methods were applied when necessary to convert API results to usable data types. Code to call the API and seed the database with records upon startup was implemented.
    - Upload files and validata input type (via file extension). 
    - Convert images to byte arrays and store in database. 
- <b>MVC design pattern & EF Core:</b>
    - Custom conroller methods
    - Dynamic Navigation Bar
    - Partial views
    - Razor syntax
- <b>SQL Server: </b>
    - Code first databse scaffolding
    - Custom method to seed the databse at startup
    - Full CRUD functionality
    - Sort records alphabetically
    - Search the database and return matching records
    - Basic input sanitization
- <b> API: </b>
    - Query the API at startup to seed database
- <b> JavaScript:</b>
    - Toggle icons
- <b> Bootstrap: </b> 
    - Version 5.3.0 
- <b> HTMl & CSS: </b>
    - Custom font
    - Defined color palette variables

# Code Summary

## Database connection
The database connection was defined and the databse named in appsettings.json file. 
A local database was declared. The database system used was SQL Server.  

## Code First classes and database
A code first approach was used to declare objects that represent each of the API resource categories. Throughout the project, the Starship class was used to CRUD highlight functionality. 

The Star Wars API returns nested JSON strings- some information is delivered as arrays. In order to parse this into the project's database, the 'nested' data needed to be converted to strings. As part of this process, additional class properties were added: one to recieve the string (which was not mapped to the db) and one to represent the stringified data. 

https://github.com/serengetijade/C_Sharp/blob/6482abff735509868e4f15baababc2a54859185d/Project_StarWarsAPI_MVC/Project_StarWarsAPI_MVC/Models/SWAPI%20Resources/Starship.cs#L43C7-L53

The database is configured with a Context file, named <a href="https://github.com/serengetijade/C_Sharp/blob/main/Project_StarWarsAPI_MVC/Project_StarWarsAPI_MVC/Data/SWContext.cs">SWContext</a>.  Within it, each declared DbSet represents a table within the database.  

To generate the database connection, the Starship class is scaffolded:
- Right Click on Controller File > Add > New Scaffolded Item
- Select: MVC Controller with views using Entity Framework
- Select: Model cass = Starship; DbContext class = SWContext

### Array to string converter
A method was written to convert 'nested' JSON array results to strings. This method is called when seeding the database, which will be discussed later. 

https://github.com/serengetijade/C_Sharp/blob/6482abff735509868e4f15baababc2a54859185d/Project_StarWarsAPI_MVC/Project_StarWarsAPI_MVC/Models/SWAPI%20Resources/SeedData.cs#L147-L164

## Seed data to the database
At startup, a method was created to call the API, apply any needed conversions (mentioned above), and save records to the database. The code is placed within a using statement, which ensures that the object called is disposed of and limits memory leaks. The object being called in this method is access to the database (via the IServiceProvider mechanism). 

Firstly, however, the method checks if any database records already exist. 
- If records exists, there is no need to seed data, so the proceeds to <a href="#Show a random database record at load time"> get a random record</a>.

https://github.com/serengetijade/C_Sharp/blob/6482abff735509868e4f15baababc2a54859185d/Project_StarWarsAPI_MVC/Project_StarWarsAPI_MVC/Models/SWAPI%20Resources/SeedData.cs#L16-L25

- If no records exists, a second using statement is started to access the API. This using statement contains the HttpClient class object, which acts as a session to send HTTP requests. Here is where the call to the API is made and the resulting JSON data is dealth with. The response is read and deserialized, arrays are <a href="Array to string converter">converted</a> to strings, and each record is saved to the database. Finally, the SeedData() method saves any changes, calls the <a href="#Show a random database record at load time"> get a random record</a> method,  and dispose of any database garbage. 

https://github.com/serengetijade/C_Sharp/blob/6482abff735509868e4f15baababc2a54859185d/Project_StarWarsAPI_MVC/Project_StarWarsAPI_MVC/Models/SWAPI%20Resources/SeedData.cs#L31-L133

## Show a random database record at load time
At each load time, a random record should be randomly shown. This requires:

A) A persistent memory location
B) A method to get a random record

### Random memory record
Upon initialization of the project, as part of the SeedData() method, an "empty" record is created. This occurs BEFORE any records are generated from the API. Doing so ensures a reliable location to be used later: the FIRST record in the database.

https://github.com/serengetijade/C_Sharp/blob/6482abff735509868e4f15baababc2a54859185d/Project_StarWarsAPI_MVC/Project_StarWarsAPI_MVC/Models/SWAPI%20Resources/SeedData.cs#L27-L31

Later in the project, when a random record is needed, it can be found at the FIRST record in the database. But how does it get there?...

### Method to get a random record
Think of this as putting everyone's name at a party into a hat and pulling one from it - there may have been more people at the party earlier, but only those still there go into the hat. An empty list is instantiated to hold Id numbers. The table is looped through and all existing Id numbers are added to the list (excluding the FIRST Id number, which is where the random record information will be duplicated). A random number is generated and data is pulled from the list at that index number, thereby providing a random Id number of a record in the database. 

https://github.com/serengetijade/C_Sharp/blob/6482abff735509868e4f15baababc2a54859185d/Project_StarWarsAPI_MVC/Project_StarWarsAPI_MVC/Models/SWAPI%20Resources/SeedData.cs#L183-L207

This random data is then saved into the FIRST database record. To be accessed later. 

To display this random data on the landing page, i.e. within the Home Controller and not the Starship Controller, the dataset was added to the Home Controller's Index() method. 

https://github.com/serengetijade/C_Sharp/blob/6482abff735509868e4f15baababc2a54859185d/Project_StarWarsAPI_MVC/Project_StarWarsAPI_MVC/Controllers/HomeController.cs#L22-L28

The other Starship records and their CRUD functions, are handled by the Starship Controller. 

## CRUD functions
When the Starship class was scaffolded, it automatically generated the basic CRUD pages. The views were customized and Bootstrap was used to display records on the index page. Stuff was done to make it pretty. Yay. 



## Search function with input sanitization
The Index() function of the Starship Controller was modified to return records that contain the given user input. The if condition was modified to exclude a few risky characters, providing some very basic input sanitization. This could be extended by a whitelist or with more specific parameters in the future.

https://github.com/serengetijade/C_Sharp/blob/6482abff735509868e4f15baababc2a54859185d/Project_StarWarsAPI_MVC/Project_StarWarsAPI_MVC/Controllers/StarshipsController.cs#L29-L45

## Dynamic nav bar
A partial view was created to represent the nav bar. It wasn't strictly necessary in this small project, but is common in larger builds. 

The search bar mentioned above appears in the nav bar and is run by the Starship Controller. So to exclude it from other controllers, logic was added to change the appearance of the nav bar. 

https://github.com/serengetijade/C_Sharp/blob/6482abff735509868e4f15baababc2a54859185d/Project_StarWarsAPI_MVC/Project_StarWarsAPI_MVC/Controllers/StarshipsController.cs#L29-L45

Similarly, a toggle icon appears only on the Home Page. This icon was attached to a music player, but it kept crashing the entire project and so was removed. The icon was left, however, to show a little <a href="https://github.com/serengetijade/C_Sharp/blob/main/Project_StarWarsAPI_MVC/Project_StarWarsAPI_MVC/wwwroot/js/site.js">java script</a>.

## Thanks and References</h5>
This project was populated using data from the Star Wars API.
Special thanks to: <a href="https://swapi.dev/" >swapi.dev</a>.

Additional thanks to <a href="https://github.com/Carla-Codes/starry-night-css-animation/tree/master" target="_blank">Carla-Codes</a> for CSS styling tips to create the starry night background. You can find her youTube channel <a href="https://www.youtube.com/watch?v=0t6Dmp70kTw" target="_blank">here</a>.
