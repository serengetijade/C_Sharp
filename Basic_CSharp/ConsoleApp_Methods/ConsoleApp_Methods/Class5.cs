using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_Methods
{
    class Class5
    {
        //Define a method(s): 
        //Syntax: accessModifier optional:returnType dataType functionName(dataType parameter)
        public void MethodVoid2(int param1)
        {
            double result = param1 / 2;
            Console.WriteLine("You CANNOT write this method to console. Instead, you must include the WriteLine in the method definition...\nMethod with a void parameter result: " + result);
        }


        public int MethodOutput(int param1, out int output)
        //When you use an output parameter, any value assigned elsewhere, like in Program.cs, gets discarded. So programmers must assign a value INSIDE the method. 
        {
            output = 100;
            output++;
            int result = param1 - 1;
            return result;
        }
        public decimal MethodOutput(int param1, decimal param2)
        {
            decimal result = param1 * param2;
            return result;
        }

        //Use the static modifier to declare a static member, which belongs to the type itself rather than to a specific object.
        public static string MethodStatic(int readNumber)
        {
            string result = "Your original number was: " + readNumber;
            return result;
        }
    }
}
