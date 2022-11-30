using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class Game
    //Game is a base (abstract) class.
    //Naming convention is to keep it generic. This class will have only those properties specific to all games, so it can be reused easily.
    {
        //Define a Property Syntax: accessModifier dataType propertyName { method; method; }   
        private List<Player> _players = new List<Player>();                                 //MUST instantiate a list to use it as a property anywhere else.
        public List<Player> Players { get { return _players; } set { _players = value; } }  
        public string Name { get; set; }
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();              //MUST instantiate a dictionary to use it as a property.
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }      
        public abstract void Play();    //By defining this property as abstract, inheriting classes MUST inherit this property.

        //Define a Method Syntax: accessModifier optional:returnType dataType functionName(dataType parameter){}
        public virtual void ListPlayers()
        {
            foreach(Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
