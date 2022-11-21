using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_Methods
{
    class Class2
    {
        //Method Overloading: multiple methods with the same name, but different contents/parameters/substance
        //Define a method(s): 
        //Syntax: accessModifier optional:returnType dataType functionName(dataType parameter)
        public int MethodOverload(int readNumber)
        {
            int result = readNumber - 100;
            return result;
        }
        public int MethodOverload(int readNumber, decimal pi)
        {
            decimal result = readNumber * pi;
            return (int)result;
        }
        public int MethodOverload(int readNumber, string stringVar)
        {
            int result = readNumber * Convert.ToInt32(stringVar);
            return result;
        }

    }
}
