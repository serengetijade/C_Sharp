using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_Methods
{
    class Class4
    {
        //Define a method: Syntax: accessModifier optional:returnType dataType functionName(dataType parameter){}
        public void MethodVoid(int param1, int param2)
        {
            int result1 = param1+50;
            Console.WriteLine("VOID method: The second parameter is: " + param2);
        }
    }
}
