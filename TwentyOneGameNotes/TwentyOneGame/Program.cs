using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate a class object, 'deck' of class 'Deck' from Deck.cs. This has a property named 'Cards', which is a list of 52 cards - defined in Deck.cs
            Deck deck = new Deck();

            deck.Shuffle(3);                    //Apply the Shuffle() method to the 'deck' instance of class Deck (as defined in Deck.cs).

            //Syntax: foreach (className instanceName1 in instanceName2.classConstructor)
            foreach (Card card in deck.Cards)   //Card = class defined in Card.cs; card = an instance of class Card as defined in Deck.cs; deck = an instance of class Deck defined above; Cards = list of Card objects as defined in Deck.cs;
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }

            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();


            //NOTES: 
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

