using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Player
    {
        //Define a constructor (the default values when an instance of this class is created). This constructor requires two property values:
        public Player(string name, int beginningBalance)    //name and beginning balance get passed in from Program.cs when called there.
        {
            //Assign the values for the properties of this class: the 'operands' of which are defined in Program.cs when a new Player object is created.
            Hand = new List<Card>();
            Balance = beginningBalance;
            Name = name;
        }

        //Define a Property Syntax: accessModifier dataType propertyName { method; method; }
        private List<Card> _hand = new List<Card>();
        public List<Card> Hand { get { return _hand; } set { _hand = value; } }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }

        //Define a Method Syntax: accessModifier optional:returnType Type functionName(dataType parameter){}
        public bool Bet(int amount)
        {
            if (Balance - amount < 0)         //If the player's balance is less that the bet, do this:
            {
                Console.WriteLine("You do not have enought to place a bet that size");
                return false;
            }
            else
            {
                Balance -= amount;            //Otherwise, if the player has enough to make the bet, subtract that amount from the balance.
                return true;
            }
        }

        //Overload an operator Syntax: accessModifier optional:returnType dataType(or ClassName) operatorToOverload(dataType parameter){}           
        public static Game operator + (Game game, Player player)    //This is an overloaded operator method.'game' and 'player' are operands.
        {
            game.Players.Add(player);       //Use the add method to add 'player' to the list 'Players', which is a property of the instance game (an instantiated class object of 'Game')
            return game;
        }
        public static Game operator - (Game game, Player player)    //This ia an overloaded operator method.'game' and 'player' are operands.
        {
            game.Players.Remove(player); 
            return game;
        }
    }
}
