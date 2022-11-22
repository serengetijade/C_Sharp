using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_AbstractClass
{
    public class Employee:Person
    {
        //Implement an inhertied method:
        public override void SayName()
        {
            string FullName = firstName + " " + lastName;
            Console.WriteLine($"Name: {FullName}");
        }
    }
}
                             