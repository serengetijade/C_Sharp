using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_AbstractClass
{
    public abstract class Person
    {
        //Define a Property Syntax: accessModifier dataType propertyName { get; set; }   
        public string firstName { get; set; }
        public string lastName { get; set; }

        //Define a Method Syntax: accessModifier optional:returnType dataType functionName(dataType parameter){}
        public virtual void SayName()
        {
            throw new NotImplementedException();
            //string FullName = firstName + " " + lastName;
            //Console.WriteLine($"Name: {FullName}");
        }
    }
}
