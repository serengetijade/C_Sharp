using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_Inheritance
{
    public class Employee<T>:Person
    //Inherit from Class 'Person'
    {
        //Add a Property (this class will have the inherited properties AND any defined here): Syntax: accessModifier dataType propertyName { method; method; }
        public int ID { get; set; }
        public List<T> Things { get; set; }

    }
}
