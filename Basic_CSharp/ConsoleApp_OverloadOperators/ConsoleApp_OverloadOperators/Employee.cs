using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_OverloadOperators
{
    public class Class1
    {
        //Define a Property Syntax: accessModifier dataType propertyName { get; set; }   
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Overload an operator Syntax: accessModifier optional:returnType dataType(or ClassName) functionName(dataType parameter){ custom implementation…. }           
        //Note that whatever datatype you declare as the operator has to match the return
        public static bool operator == (Class1 C1instance1, Class1 C1instance2)
        {
            bool status = C1instance1.ID.Equals(C1instance2.ID);
            return status;
        }          
        public static bool operator != (Class1 C1instance1, Class1 C1instance2)
        {
            bool status = C1instance1.ID != C1instance2.ID;
            return status;
        } 
    }
}
