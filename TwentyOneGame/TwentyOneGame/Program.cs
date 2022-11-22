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
            //NOTES: 
            ////Syntax: className instanceName = new className();
            ////Syntax to define a property value: instanceName.propertyName = value;
            //Card cardOne = new Card();
            //cardOne.Face = "Queen";
            //cardOne.Suit = "Spades";
            ////Object Initialization: a faster way to initiate an object and assingn values to its properties
            //Card cardOne = new Card() {Face = "King", Suit = "Spades"};              
            ////Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);


            //Instantiate a TwentyOneGame object:
            TwentyOneGame game = new TwentyOneGame();

            ////Instatiate a Deck object and add a Card object to it: 
            //Deck deck = new Deck();
            //deck.Cards = new List<Card>();
            //deck.Cards.Add(cardOne);
            //Instantiate a class object, 'deck' of class 'Deck' from Deck.cs. This has a property named 'Cards', which is a list of 52 cards - defined in Deck.cs
            Deck deck = new Deck();
            
            deck.Shuffle(3);     //Apply the Shuffle() method to the 'deck' instance of class Deck (as defined in Deck.cs).
            ////Or to use the Shuffle() method (as defined below), reassign the value of deck/apply the Shuffle() method to it: 
            //int timesShuffled = 0;
            //deck = Shuffle(deck: deck , out timesShuffled, times: 3);   //Call the third Shuffle method using NAMED parameters

            //Syntax: foreach (className instanceName1 in instanceName2.classConstructor)
            //Syntax breakdown: Card = class defined in Card.cs; card = an instance of class Card as defined in Deck.cs; deck = an instance of class Deck defined above; Cards = list of Card objects as defined in Deck.cs;
            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }

            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
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
    }
}

