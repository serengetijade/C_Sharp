using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    //'public' means that this class is accessible to other parts of the program. 
    public class Card
    {
        /*//Define a constructor (the default values when an instance of this class is created):
        public Card() 
        {
            Suit = "Spades";
            Face = "Two";
        } */
        //Define a Property- Syntax: accessModifier dataType propertyName { method; method; }
        public string Suit { get; set; }
        public string Face { get; set; }
    }
}
