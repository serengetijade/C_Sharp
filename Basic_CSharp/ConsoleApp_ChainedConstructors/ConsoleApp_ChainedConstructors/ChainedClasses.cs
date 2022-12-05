using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_ChainedConstructors
{
    //To chain constructors, you must first define the class and its properties
    class className
    {
        //Define a Property Syntax: accessModifier Type propertyName { get; set; }   
        public string Name { get; set; }
        public int ID { get; set; }

        //Define a constructor method: the default values when an instance of this class is created
        public className(string name, int id)   //'name' and 'ID' are placeholders to represent the required/passed in values when the constructor function is called.
        {
            Name = name;           //class property = passed in value
            ID = id;
        }

        //Chain the constructor: when there is a name value, but no id value
        public className(string name) : this(name, 11)
        {
        }

        //Chain the constructor: when there is an id value, but no name value
        public className(int id) : this("Name", id)
        {
        }
    }
}
