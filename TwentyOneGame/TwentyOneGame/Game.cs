﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    public abstract class Game
    //Game is a base (abstract) class.
    //Naming convention is to keep it generic. This class will have only those properties specific to all games, so it can be reused easily.
    {
        //Define a Property Syntax: accessModifier dataType propertyName { method; method; }   
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        //Define a Method Syntax: accessModifier optional:returnType dataType functionName(dataType parameter){}
        public virtual void ListPlayers()
        {
            foreach(Player player in Players)
            {
                Console.WriteLine(player);
            }
        }
        public abstract void Play();    //By defining this property as abstract, inheriting classes MUST inherit this property.

    }
}
