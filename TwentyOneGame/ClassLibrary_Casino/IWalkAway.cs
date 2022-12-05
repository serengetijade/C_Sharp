using System;
using System.Collections.Generic;
using System.Text;

//Create another Namespace:
namespace ClassLibrary_Casino.Interfaces
{
    interface IWalkAway
    {
        //Define a Method Syntax: accessModifier optional:returnType dataType functionName(dataType parameter){}
        void WalkAway(Player player);
    }
}
