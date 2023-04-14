using System;
using ClassLibrary_Casino;          //Custom Library
using ClassLibrary_Casino.TwentyOne;//Custom Library subclass
using System.IO;
using System.Data.SqlClient;        //SQL
using System.Data;                  //SQL
using System.Collections.Generic;   //Lists

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Hotel and Casino. \nLet's start by telling me your name. ");
            string playerName = Console.ReadLine();
            if (playerName.ToLower() == "admin")  //Show a list of exceptions to admin:
            {
                //Create a list of the entities pulled from the DB, and call the ReadExceptions method:
                List<ExceptionEntity> Exceptions = ReadExceptions();   //defined below)
                foreach (var exception in Exceptions)
                {
                    Console.Write(exception.ID + " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp + " | ");
                    Console.WriteLine();
                }
                Console.Read();
                return;
            }

            //Exception handling: with boolean, TryParse, and a while loop
            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);    //TryParse is a method that has required out parameters (input*, out variableName);  *input may be a Console.ReadLine(), or another variable
                if (!validAnswer) Console.WriteLine("Please enter whole numbers only.");
            }

            Console.WriteLine("Hello, {0}. Would you like to join a game of 21?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);       //Instantiate the constructor (defined in Player.cs) and pass in propery values.
                player.Id = Guid.NewGuid();                         //Define a property value for this instance's 'Id' property (defined in Player.cs).
                //Log the player's Guid to a .txt file:
                using (StreamWriter file = new StreamWriter(@"C:\Users\jad24\Documents\CodingProjects\C_Sharp\TwentyOneGame\TwentyOneGame\log.txt", true))
                {
                    file.WriteLine(player.Id);
                }
                
                Game game = new TwentyOneGame();                    //Instantiate a Game instance using polymorphism (define in GameTwentyOne.cs) to expose the overloaded operators.
                game += player;                                     //Use the overloaded operator to add player to this game instance.
                player.isActivelyPlaying = true;                    //Set the 'player' instance property value of 'isActivelyPlaying'(defined in Player.cs) to true.
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play(); 
                    }
                    catch (FraudException ex) //Best practice is to be as specific as possible with exceptions. And to start with the most specific, before the generic "Exception".
                    {
                        Console.WriteLine(ex.Message);     //When this exception occurs, write the message associate with that instance (defined in TwentyOneGame.cs).
                        UpdateDBWithException(ex);
                        Console.ReadLine();
                        return; 
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occured. Please contact your system administrator.");
                        UpdateDBWithException(ex);
                        Console.ReadLine();
                        return; //when you type return in a void method, it ends the method.
                    }
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Bye for now.");
            Console.Read();

            //NOTES:     
            ////Instantiate a class object, 'deck' of class 'Deck' from Deck.cs. This has a property named 'Cards', which is a list of 52 cards - defined in Deck.cs
            //Deck deck = new Deck();

            //deck.Shuffle(3);                    //Apply the Shuffle() method to the 'deck' instance of class Deck (as defined in Deck.cs).

            ////Syntax: foreach (className instanceName1 in instanceName2.classConstructor)
            //foreach (Card card in deck.Cards)   //Card = class defined in Card.cs; card = an instance of class Card as defined in Deck.cs; deck = an instance of class Deck defined above; Cards = list of Card objects as defined in Deck.cs;
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}

            //Console.WriteLine(deck.Cards.Count);
            //Console.ReadLine();

            ////Syntax: className instanceName = new className();
            ////Syntax to define a property value: instanceName.propertyName = value;
            //Card cardOne = new Card();
            //cardOne.Face = "Queen";
            //cardOne.Suit = "Spades";
            ////Object Initialization: a faster way to initiate an object and assign values to its properties. Syntax: className instanceName = new className() {property1 = value1, property2 = value2};
            //Card cardOne = new Card() {Face = "King", Suit = "Spades"};              
            ////Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);
            ////Instatiate a Deck object and add a Card object to it: 
            //Deck deck = new Deck();
            //deck.Cards = new List<Card>();
            //deck.Cards.Add(cardOne);

            ////Instantiate a TwentyOneGame object:
            //TwentyOneGame game = new TwentyOneGame();
            ////Define the property value for the instance 'game':
            //game.Players = new List<string>() { "Jesse", "Bob", "Bill", "Thomas" };
            ////Call a Class Method for this instance object:
            //game.ListPlayers(); 

            ////Instantiate a (polymorphic) object and assign values to its parameters: 
            //Game game = new TwentyOneGame();   
            //game.Players = new List<Player>();  //Instantiate a 'Players' list (from Game.cs) so that it can be used later. It is made up of 'Player' objects from Player.cs. 
            //Player player = new Player();       //Instantiate a 'Player object (from Player.cs) and name it 'player'
            //player.Name = "Jesse";              //Assign a property value (Name from Player.cs)of the 'player' instance
            //game += player;                     //Shorthand for: game = game + player;   
            //game -= player;                     //Shorthand for: game = game - player;

            ////Instantiate an object and assign its property value(s) using an enum Type (defined in Card.cs):
            //Card card = new Card();
            //card.Suit = Suit.Clubs;
        }

        private static void UpdateDBWithException(Exception ex)  
        //private makes this only accessible to objects of this class. static means programmer does not have to instantiate an object to use this class. void means that this method doesn't return anything. 
        {
            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = TwentyOneGame; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";

            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES
                                    (@ExceptionType, @ExceptionMessage, @TimeStamp)";        //Use @whatever as parameterized queries. @whatever is a placeholder, then ADO.NET will create parameters that map in to those placeholders.. 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //SQL Command Syntax: SqlCommand variable = new SqlCommand(queryString, connection);
                SqlCommand command = new SqlCommand(queryString, connection);
                //Data Type Syntax: variable.Parameters.Add("@ParameterName", SqlDbType.Type*) *the SQL type, NOT the C# type
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);
                //Add Parameter values Syntax: variable.Parameters["@ParameterName"].Value = 
                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                //Open connection, execute command, and close connection:
                connection.Open();
                command.ExecuteNonQuery();       //Because it is an insert statement, it is non-query
                connection.Close();
            }
        }

        private static List<ExceptionEntity> ReadExceptions()
        {
            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = TwentyOneGame; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";

            string queryString = @"Select Id, ExceptionType, Exceptionmessage, TimeStamp FROM Exceptions";

            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);  //create new SQL command object. This is NOT a parameterized query.

                //Open connection, execute command, and close connection:
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();  //Instantiate a SQLDataRead object and assign it (by applying to this instance) the built in method ExecuteReader()
                while (reader.Read())  //Loop through each record. For each record, do the following:  
                {
                    ExceptionEntity exception = new ExceptionEntity();  //Create a new object (defined in ExceptionEntity.cs)
                    exception.ID = Convert.ToInt32(reader["ID"]);  //Map what is read from the DB to this instance's parameters (defined in ExceptionEntity.cs)
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    Exceptions.Add(exception);  //Add this instance (and all its parameter details) to the Exceptions lists created above. 
                }
                connection.Close();
            }
            return Exceptions;
        }

        ////NOTES: METHOD 1
        ////Define a function to use random method and removeAt method to randomize the order of objects in the (Deck) list: 
        ////Syntax: accessModifier returnType dataType functionName(dataType parameter)
        ////returnType is static so that this method can be called withouth instantiating an object.
        //public static Deck Shuffle(Deck deck)
        //{
        //    //Create a temporary list to store shuffled objects:
        //    List<Card> TempList = new List<Card>();
        //    //Random method:
        //    Random random = new Random();

        //    while (deck.Cards.Count > 0)
        //    {
        //        int randomIndex = random.Next(0, deck.Cards.Count);
        //        TempList.Add(deck.Cards[randomIndex]);
        //        deck.Cards.RemoveAt(randomIndex);
        //    }
        //    deck.Cards = TempList;
        //    return deck;
        //}

        ////METHOD 2
        ////Method Overloading: multiple methods with the same name, but different contents/parameters/substance
        ////This method uses a loop to apply the Shuffle method to every iteration:
        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i ++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}

        ////METHOD 3
        ////Assign a parameter with a default value
        ////Assign an out variable BEFORE optional parameters
        //public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)
        //{
        //    timesShuffled = 0;
        //    for (int i = 0; i < times; i++)
        //    {
        //        timesShuffled++;
        //        //Create a temporary list to store shuffled objects:
        //        List<Card> TempList = new List<Card>();         
        //        Random random = new Random();    //Use the Random method

        //        while (deck.Cards.Count > 0)
        //        {
        //            int randomIndex = random.Next(0, deck.Cards.Count);
        //            TempList.Add(deck.Cards[randomIndex]);
        //            deck.Cards.RemoveAt(randomIndex);
        //        }
        //        deck.Cards = TempList;
        //    }
        //    return deck;

        ////Instead of deck.Shuffle(#) as used above, use the Shuffle() method (See NOTES: Method 1, 2, and 3 above), assign the value of deck/apply the Shuffle() method to it: 
        //int timesShuffled = 0;
        //deck = Shuffle(deck: deck , out timesShuffled, times: 3);   //Call the third Shuffle method using NAMED parameters
    }
}