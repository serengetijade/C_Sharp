using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_AbstractClass
{
    public class Employee:Person, IQuittable
    {
        //Implement an inhertied method:
        public override void SayName()
        {
            string FullName = firstName + " " + lastName;
            Console.WriteLine($"Name: {FullName}");
        }

        //To inherit an interface method, MUST implement it (and it must match the interface definition): 
        public void Quit()
        {
            Console.WriteLine("IQuit Method");
            //throw new NotImplementedException();
        }
    }
}
                             