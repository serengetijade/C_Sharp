using System;

namespace ConsoleApp_OverloadOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Object Initialization: a faster way to initiate an object and assign values to its properties. 
            //Syntax: className instanceName = new className() { property1 = value1, property2 = value2 };
            Class1 C1instance1 = new Class1() { ID = 1, FirstName = "Fred", LastName = "Rogers" };
            Class1 C1instance2 = new Class1() { ID = 2, FirstName = "Bill", LastName = "Nye" };

            Console.WriteLine("Does object one equal object 2? ");
            Console.WriteLine(C1instance1.ID == C1instance2.ID);
            Console.WriteLine(C1instance1.ID != C1instance2.ID);

            Console.ReadLine();

            //Object Initialization: 
            Box box1 = new Box(2, 2, 2);
            Box box2 = new Box(2,2,2);
            Box box3 = box1 + box2; 
            Console.WriteLine("Overloaded '+' operator with programmer defined 'Box' objects: " + "\nLength: " + box3.GetLength() + "\nWidth: " + box3.GetWidth() + "\nHeight: " + box3.GetHeight());
        }
    }
}
