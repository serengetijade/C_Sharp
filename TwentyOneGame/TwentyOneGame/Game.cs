﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOneGame
{
    public class Game
    //Naming convention is to keep it generic. This class will have only those properties specific to all games, so it can be reused easily.
    {
        //Define the properties for this class. Syntax: accessModifier dataType propertyName { method; method; }  
        public List<string> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }
        public void ListPlayers()
        {
            foreach(string player in Players)
            {
                Console.WriteLine(player);
            }
        }

    }
}