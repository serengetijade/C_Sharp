using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_Methods
{
    class Class3
    {
        //Define a method with a DEFAULT parameter:
        //Syntax: accessModifier optional:returnType dataType functionName(dataType parameter=value){}
        public static int MethodDefaultParam(int readNumber, int defaultParam = 1)
        {
            int result = readNumber + defaultParam;
            return result;
        }
    }
}
