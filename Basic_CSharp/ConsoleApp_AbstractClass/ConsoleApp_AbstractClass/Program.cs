using System;

namespace ConsoleApp_AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee instance1 = new Employee() { firstName = "Sample", lastName = "Student"};
            instance1.SayName();
            Console.ReadLine();
        }
    }
}
