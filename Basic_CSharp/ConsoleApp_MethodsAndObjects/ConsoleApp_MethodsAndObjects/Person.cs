using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_Inheritance

{
    //Object literal: 
    public class Person
    {
        //Define a Property- Syntax: accessModifier dataType propertyName { method; method; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Define a Method- Syntax: accessModifier optional:returnType dataType functionName(dataType parameter){}
        //Parameters are any data/objects required by the function.
        public void SayName()
        {
            string FullName = FirstName + " " + LastName;
            Console.WriteLine($"Name: {FullName}");
        }

        //Constructor: a constructor is called as the "default" instantiation of this object class if no parameters are provided.
        //A constructor is a method. It creates an object of this class. 
        public Person(string FN, string LN)
        {
            FN = "First Name";
            LN = "Last Name";
        }
    }

    //Abstract Class = the base class. An instance of any abstract class CANNOT be instantiated, only instances of the child class(es). 
    abstract class Animal { }

    class Dog : Animal { }

    //Virtual and Override Keywords
    class BaseClass {
        //In order to a method from the base class to be changed later, it MUST include the keyword 'virtual'. 
        public virtual void methodName()
        {
            Console.WriteLine("This is the BaseClass method.");
        }
    }

    class ChildClass : BaseClass
    {
        //In order to change an inherited method, it MUST contain the keyword 'override'. 
        public override void methodName()
        {
            Console.WriteLine("This is the ChildClass method.");
        }
    }


}

