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
            ////Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);

            ////Instatiate a Deck object and add a Card object to it: 
            //Deck deck = new Deck();
            //deck.Cards = new List<Card>();
            //deck.Cards.Add(cardOne);

            //Instantiate a class object, 'deck' of class 'Deck' from Deck.cs. This has a property named 'Cards', which is a list of 52 cards - defined in Deck.cs
            Deck deck = new Deck();
            //Reassign the value of deck/apply the shuffle method to it: 
            deck = Shuffle(deck);

            //Syntax: foreach (className instanceName1 in instanceName2.classConstructor)
            //Syntax breakdown: Card = class defined in Card.cs; card = an instance of class Card as defined in Deck.cs; deck = an instance of class Deck defined above; Cards = list of Card objects as defined in Deck.cs;
            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }

            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

        //Use random method and removeAt method to randomize the order of objects in the list: 
        //Syntax: accessModifier returnType dataType functionName(dataType parameter)
        public static Deck Shuffle(Deck deck)
        {
            //Create a temporary list to store shuffled objects:
            List<Card> TempList = new List<Card>();
            //Random method:
            Random random = new Random();

            while (deck.Cards.Count > 0)
            {
                int randomIndex = random.Next(0, deck.Cards.Count);
                TempList.Add(deck.Cards[randomIndex]);
                deck.Cards.RemoveAt(randomIndex);
            }
            deck.Cards = TempList;
            return deck;
        }
    }
}
