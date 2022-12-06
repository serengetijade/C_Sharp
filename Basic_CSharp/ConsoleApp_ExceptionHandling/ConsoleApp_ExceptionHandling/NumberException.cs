using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_ExceptionHandling
{
    public class NumberException: Exception
    {
        //Define a class constructor method: implement the same implementation that exists for Exception. 
        public NumberException()
            : base() { }    //Inherit from base() Exception
    }
}
