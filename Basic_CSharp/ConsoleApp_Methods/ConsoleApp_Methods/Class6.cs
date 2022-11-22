using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_Methods
{
    static class Class6
    //A static class CANNOT be instantiated. 
    {
        //Define a Property Syntax: accessModifier optional:returnType dataType propertyName { method; method; }   
        public static string String1 { get; set; }

        //Define a Method Syntax: accessModifier optional:returnType dataType functionName(dataType parameter){}
        public static void StaticMethod()
        {
            Console.WriteLine("This is a static method");
        }
    }
}
