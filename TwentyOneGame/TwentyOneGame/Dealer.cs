using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    class Dealer
    {
        //Define a Property- Syntax: accessModifier dataType propertyName { method; method; }
        public string Name { get; set; }
        public Deck Deck { get; set; }      //Cannot inherit the Deck class because the dealer 'has a deck'. A dealer is NOT a type of deck.
        public int Balance { get; set; }

        //Define a Method- Syntax: accessModifier optional:returnType dataType functionName(dataType parameter){}
        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First()); //Use the First() method to retireve the first item of a list.
            Console.WriteLine(Deck.Cards.First().ToString() + "\n");
            Deck.Cards.RemoveAt(0);  //Use RemoveAt() method to remove an item from a list at a given index location.
        }
    }
}
