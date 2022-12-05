using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibrary_Casino
{
    public class Player
    {
        //Define a constructor call chain (the default values when an instance of this class is created, but using another constructor, defined below). This constructor requires one property values: name, and the second (beginning balance) is defined by a default value of 100.
        public Player(string name) : this(name, 100)
        {
        }

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
        public Guid Id { get; set; }    //Create a unique Guid for each Player

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
