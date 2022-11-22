using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    //Inherit from Game Class: 
    public class TwentyOneGame : Game, IWalkAway
    {
        //Because methods from the parent class are defined as abstract in Game.cs, MUST apply the OVERRIDE keyword to modify it
        public override void Play()    
        {
            throw new NotImplementedException();
        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 Players: ");
            base.ListPlayers();
        }

        //To inherit an interface method, MUST implement it (and it must match the interface definition): 
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
