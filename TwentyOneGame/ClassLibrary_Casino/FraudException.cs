using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary_Casino
{
    public class FraudException: Exception        //Inherit from Exception (a built-in class)
    {
        //Define a class constructor method: implement the same implementation that exists for Exception. 
        public FraudException() 
            : base() { }    //Inherit from base() Exception
        //Overload this method: (it is different because it takes one argument)
        public FraudException(string message) 
            : base(message) { } //Inherit from base() Exception
    }
}
