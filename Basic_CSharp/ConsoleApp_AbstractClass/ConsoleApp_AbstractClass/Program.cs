using System;

namespace ConsoleApp_AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate an Employee object:
            Employee instance1 = new Employee() { firstName = "Sample", lastName = "Student"};
            //Call a (Employee) Class Medhod: 
            instance1.SayName();
            Console.ReadLine();
        }
    }
}
