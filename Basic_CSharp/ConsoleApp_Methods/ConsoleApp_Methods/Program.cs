using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number:");
            try
            {
                int readNumber = Convert.ToInt32(Console.ReadLine());
                //Call a Class/method (defined in Class1.cs):
                //instantiate a class object...
                Class1 class1Instance = new Class1();
                //call a class method...this method uses static to apply a method without having to instantiate an object of that class:  
                if (Class1.Method1(readNumber) == 0)
                {
                    Console.WriteLine("Method1 result: "+ Class1.Method1(readNumber) + " is an even number.");
                }
                else
                {
                    Console.WriteLine(readNumber + " is an odd number.");
                }
                //call a class method...instantiate an object of that class:  
                int class1method2 = class1Instance.Method2(readNumber);
                int class1method3 = class1Instance.Method3(readNumber);
                Console.WriteLine("Method2 result: " + class1method2);
                Console.WriteLine("Method3 result: " + class1method3);

            }
            catch (FormatException ex)
            {
                Console.WriteLine("You did not enter a whole number.");
                Console.WriteLine("Please enter a whole number:");
                int readNumber = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
