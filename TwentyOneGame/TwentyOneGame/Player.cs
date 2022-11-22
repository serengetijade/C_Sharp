using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    public class Player
    {
        //Define a Property Syntax: accessModifier dataType propertyName { method; method; }
        public List<Card> Hand { get; set;}
        public int Balance { get; set; }
        public string name { get; set; }
        public bool isActivelyPlaying { get; set; }
    }
}
