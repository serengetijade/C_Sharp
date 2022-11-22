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

            //Polymorphism: Instantiate an of a new 'derived class' object, then call a Method:
            IQuittable polyObject = new Employee();
            polyObject.Quit();

            Console.ReadLine();
        }
    }
}
