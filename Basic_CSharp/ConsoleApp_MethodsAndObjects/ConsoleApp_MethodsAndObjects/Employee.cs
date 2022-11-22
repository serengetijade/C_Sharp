using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_MethodsAndObjects
{
    public class Employee:Person
    //Inherit from Class 'Person'
    {
        //Define a Property: Syntax: accessModifier dataType propertyName { method; method; }
        public int ID { get; set; }
    }
}
