using System;

namespace ConsoleApp_MethodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //Object Initialization Syntax: className instanceName = new className() {property1 = value1, property2 = value2};
            Employee instance1 = new Employee() { FirstName = "Sample", LastName = "Student", ID = 1 };
            instance1.SayName();
        }

        Console.ReadLine();
    }
}
