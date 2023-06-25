using System;
using System.ComponentModel;

namespace ConsoleApp_Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate a structure object Syntax: structureName instanceName = new structureName(); 
            Numbers instance1 = new Numbers() { Amount = 11 };

            Console.WriteLine(instance1.Amount);

        }

        struct ExampleStruct
        {
            string exString;
            int exInt;
        }
    }
}
