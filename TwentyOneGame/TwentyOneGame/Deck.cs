using System;
using System.Collections.Generic; //Required to use lists
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        //Define a Property Syntax: accessModifier dataType propertyName { method; method; }
        private List<Card> _cards = new List<Card>();
        public List<Card> Cards { get { return _cards; } set { _cards = value; } }  

        //Define a class Method:
        public Deck()
        {
            //Define a Card Class Constructor: Instantiate an empty list object so that it can be used later. 
            Cards = new List<Card>();           //'Cards' is an empty list of 'Card' type objects, which include any property of the class as defined in Card.cs.

            //Use a for loop to instantiate Card objects, assign their property values, and add them to the Cards list.
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i;       //Use explicit casting to change the Type from an int to Face, ie the name of the enumerator.
                    card.Suit = (Suit)j;
                    Cards.Add(card);
                }
            }

            //NOTES:
            //Add a single object to this class: 
            //Cards = new List<Card>();
            //Card cardOne = new Card();
            //cardOne.Face = "Two";
            //cardOne.Suit = "Hearts";
            //Cards.Add(cardOne);
            
            ////Define lists to become property values: 
            //List<string> Suits = new List<string>() {"Clubs", "Hearts", "Diamonds", "Spades" };
            //List<string> Faces = new List<string>() {"Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" };
            ////Use nested foreach loop to create/add objects to 'Cards' list: 
            //foreach (string face in Faces)
            //{
            //     foreach (string suit in Suits)
            //    {
            //        //Instantiate a Class Object Syntax: className instanceName = new className();
            //        Card card = new Card();
            //        card.Suit = suit;
            //        card.Face = face;
            //        Cards.Add(card);
            //    }
            //}
        }

        //Define a Method with a parameter that has a default value:
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
                //Cards = TempList;
                this.Cards = TempList;    //this. refers to this method: the class this method is inside of
            }   
        }
    }
}
