using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_Methods
{
    static class Class6
    //A static class CANNOT be instantiated. 
    {
        public static string String1 { get; set; }
       
        //Define a method:
        public static void StaticMethod()
        {
            Console.WriteLine("This is a static method");
        }
    }
}
