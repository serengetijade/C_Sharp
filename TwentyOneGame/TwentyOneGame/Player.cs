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
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }

        //Overload an operator Syntax: accessModifier optional:returnType dataType(or ClassName) operatorToOverload(dataType parameter){}           
        public static Game operator + (Game game, Player player)    //This is an overloaded operator method.'game' and 'player' are operands.
        {
            game.Players.Add(player);   //Use the add method to add 'player' to the list 'Players', which is a property of the instance game (an instantiated class object of 'Game')
            return game;
        }
        public static Game operator - (Game game, Player player)    //This ia an overloaded operator method.'game' and 'player' are operands.
        {
            game.Players.Remove(player); 
            return game;
        }
    }
}
