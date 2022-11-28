using System;

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
    }
}
