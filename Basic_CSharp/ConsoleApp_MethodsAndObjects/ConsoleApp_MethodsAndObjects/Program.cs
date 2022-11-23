using System;
using System.Collections.Generic;

namespace ConsoleApp_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Object Initialization Syntax: className<Type> instanceName = new className<Type>() {property1 = value1, property2 = value2};
            //because Employee is a generic class, MUST define Type for every intantiation
            Employee<string> instance1 = new Employee<string>() { FirstName = "Sample", LastName = "Student", ID = 1 };  
            instance1.SayName();

            //Instantiate a list object from the instance1 of the Employee class
            instance1.Things = new List<string>() { "value1", "value2", "value3"};

            var x = instance1.Things;
            for (int i = 0; i < x.Count; i++) { }

            //In order to instantiate  a list object with different Type, you must use a (different) instance with a matching Type.
            Employee<int> instance2 = new Employee<int>();
            instance2.Things = new List<int>() { 5, 11, 13 };  
            
            Console.ReadLine();
        }
    }
}
