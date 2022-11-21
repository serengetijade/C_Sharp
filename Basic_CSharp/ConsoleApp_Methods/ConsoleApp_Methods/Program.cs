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
            int readNumber = Convert.ToInt32(Console.ReadLine());
            try
            {
                //Call a Class/method (defined in Class1.cs):
                //instantiate a class object...
                Class1 class1Instance = new Class1();
                //call a (static) class method...this method uses static to apply a method without having to instantiate an object of that class:  
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

                //Call an overloaded Class/method (defined in Class2.cs):
                Class2 class2Instance = new Class2();

                int class2methodOverload = class2Instance.MethodOverload(readNumber);
                Console.WriteLine("Overloaded method result 1: " + class2methodOverload);

                class2methodOverload= class2Instance.MethodOverload(readNumber, 3.1415m);
                Console.WriteLine("Overloaded method result 2: {0}", class2methodOverload);

                class2methodOverload = class2Instance.MethodOverload(readNumber, "2");
                Console.WriteLine($"Overloaded method result 3: {class2methodOverload}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("You did not enter a whole number.");
                Console.WriteLine("Please enter a whole number:");
                readNumber = Convert.ToInt32(Console.ReadLine());
            }
            try
            {
                //Call a (static) method that has a parameter with a default parameter: 
                Console.WriteLine("Enter a second number, if you so choose- this is not strictly necessary.");
                int defaultParam = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Method with a default parameter result: " + Class3.MethodDefaultParam(readNumber, defaultParam));
            }
            catch
            {
                Console.WriteLine("Method with a default parameter result: " + Class3.MethodDefaultParam(readNumber));
            }
            Console.ReadLine();
        }
    }
}
