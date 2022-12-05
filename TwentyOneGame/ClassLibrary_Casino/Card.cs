using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Casino
{
    //Define a struct Type
    public struct Card      
    {
        //Define a Property- Syntax: accessModifier Type propertyName { method; method; }  //Usethe enum Type defined below
        public Suit Suit { get; set; }    
        public Face Face { get; set; }

        //Use override to create a custom ToString() method to return "Face" of "Suit":
        public override string ToString()
        {
            return string.Format("{0} of {1}", Face, Suit);
        }

        ////Define a constructor (the default values when an instance of this class is created):
        //public Card() { Suit = "Spades"; Face = "Two";} 
    }

    //Define an enum - a set of Types
    public enum Suit
    {
        Clubs,       //To assign an underlying value: Clubs=value,
        Diamonds,
        Hearts,
        Spades
    }
    public enum Face
    {
        Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King
    }
}
