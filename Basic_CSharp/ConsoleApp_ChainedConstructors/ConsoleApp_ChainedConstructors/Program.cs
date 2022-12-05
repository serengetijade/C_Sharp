using System;
using System.Collections.Generic;  //Required for dictionaries and lists

namespace ConsoleApp_ChainedConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            const string constantName = "Constant Value";

            //Initialize a Dictionary Syntax with var:  accessModifier optional:returnType var dictionaryName = new Dictionary<optional:requiredParameters, Type>()
            var dictionaryName = new Dictionary<string, int> { };
            //Initialize a Dictionary Syntax WIHTOUT var: accessModifier optional:returnType Dictionary<optional:requiredParameters, Type> dictionaryName = new Dictionary<keyType, valueType>() { [requiredParameter.parameterValue] = value, [requiredParameter.parameterValue] = value, }; 
            //Dictionary<int, string> dictName = new Dictionary<int, string>() { };  

           
            //Chained constructors:
            Console.WriteLine("Please enter an input value, such as your name");
            string name = Console.ReadLine();

            //To use the constructor: first instantiate the class, then pass in value(s)
            className classNameInstance = new className("Dalton", 2022);
        }
    }
}