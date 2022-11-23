using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_Inheritance
{
    public class Person
    {
        //Define a Property- Syntax: accessModifier dataType propertyName { method; method; }   
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Define a Method- Syntax: accessModifier optional:returnType dataType functionName(dataType parameter){}
        public void SayName()
        {
            string FullName = FirstName + " " + LastName;
            Console.WriteLine($"Name: {FullName}");
        }

    }
}
