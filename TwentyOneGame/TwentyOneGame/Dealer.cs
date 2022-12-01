using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOne
{
    public class Dealer
    {
        //Define a Property Syntax: accessModifier dataType propertyName { method; method; }
        public string Name { get; set; }
        public Deck Deck { get; set; }  //Note: Cannot inherit the Deck class because the dealer 'has a deck'. A dealer is NOT a type of deck.
        public int Balance { get; set; }

        //Define a Method Syntax: accessModifier optional:returnType dataType functionName(dataType parameter){}
        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());  //Use the First() method to retireve the first item of a list. Hand is a property of the Player class, it is a List consisting of <Card> type objects. Deck is a Deck type (defined in Deck.cs) property of Dealer. As a Deck type, it is a Deck class objeck with a property Cards, which is a List consisting of <Card> type objects. First is a method that retrieves the first object of that list.
            string card = string.Format(Deck.Cards.First().ToString() + "\n");    //Apply the overridden ToString method (defined in Card.cs).
            Console.WriteLine(card);
            //Write each card delt to a txt file:
            using (StreamWriter file = new StreamWriter(@"C:\Users\jad24\Documents\Coding Projects\C_Sharp\TwentyOneGame\TwentyOneGame\log.txt", true))
            {
                file.WriteLine(DateTime.Now);       //Use DateTime with .Now method to create a "timestamp".
                file.WriteLine(card);                
            }
            Deck.Cards.RemoveAt(0);  //Use RemoveAt() method to remove an object from a list at a given index location, in this case it is the zero index (the first) object that was 'dealt out'.
        }
    }
}
