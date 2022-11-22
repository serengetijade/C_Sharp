using System;
using System.Collections.Generic; //Required to use lists
using System.Text;

namespace TwentyOneGame
{
    public class Deck
    {
        public Deck()
        {
            //NOTES: Add a single object to this class: 
            //Cards = new List<Card>();
            //Card cardOne = new Card();
            //cardOne.Face = "Two";
            //cardOne.Suit = "Hearts";
            //Cards.Add(cardOne);

            //Define a class constructor: 'Cards' is an empty list of 'Card' objects, which include any property of the class as defined in Card.cs
            Cards = new List<Card>();

            //Define lists to become property values: 
            List<string> Suits = new List<string>() {"Clubs", "Hearts", "Diamonds", "Spades" };
            List<string> Faces = new List<string>() {"Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" };
            
            //Use nested foreach loop to create/add objects to 'Cards' list: 
            foreach (string face in Faces)
            {
                 foreach (string suit in Suits)
                {
                    //Class Object Syntax: className instanceName = new className();
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);
                }
            }
        }
        //Define the properties for this class. Syntax: accessModifier dataType propertyName { method; method; }   
        public List<Card> Cards { get; set; }  //The Cards property (which is a list):

        //Define a method with a parameter that has a default value:
        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                //Create a temporary list to store shuffled objects:
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                //this.Cards = TempList;    //this. refers to this method, the class this method inside of
                Cards = TempList;
            }   
        }
    }
}
