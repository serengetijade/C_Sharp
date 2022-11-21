using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_Methods
{
    class Class1
    {
        //Define a method(s): 
        //Syntax: accessModifier optional:returnType dataType functionName(dataType parameter)
        public static int Method1(int readNumber)
        {
            int even = readNumber % 2;
            return even;
        }
        public int Method2(int readNumber)
        {
            int plusTen = readNumber + 10;
            return plusTen;
        }
        public int Method3(int readNumber)
        {
            int mulitplyTen = readNumber * 10;
            return mulitplyTen;
        }
    }
}
