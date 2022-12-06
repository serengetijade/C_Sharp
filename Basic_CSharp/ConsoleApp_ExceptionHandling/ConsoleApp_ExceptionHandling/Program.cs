using System;
using System.Collections.Generic; //required for Lists
using ConsoleApp_ExceptionHandling;

namespace ExceptionHandling
{
    class ExceptionHandling
    {
        static void Main(string[] args)
        {
            /*TRY CATCH FINALLY NOTES:
            try
            {
                Console.WriteLine("Picke a number.");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a second number.");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing the two.....");
                int numberThree = numberOne / numberTwo;
                Console.WriteLine(numberOne + " divided by " + numberTwo + " equals: " + numberThree);
            }
            //This will catch when a 'FormatException' occurs, and assigns that to the variable 'ex':
            //Other exceptions are available, like 'Exception'.
            catch (FormatException ex)
            {
                //Define the message when this exception occurs:
                //Console.WriteLine(ex.Message);
                Console.WriteLine("Please type a valid number.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You cannot divide by zero");
            }
            //Exception will catch any other exception that is not explicitly defined:
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //Code to run regardless of an error or not: 
            finally
            {
                Console.ReadLine();
            }
            */

            List<int> numbers = new List<int>() { 1, 2, 33, 4, 5, 66, 7, 8, 99, 10 };
            try
            {
                Console.WriteLine("Please enter a number");
                decimal number = Convert.ToDecimal(Console.ReadLine());
                for (int i = 0; i < numbers.Count; i ++)
                {
                    Console.WriteLine(numbers[i] / number);
                    //If 0 is entered: System.DivideByZeroException: 'Attempted to divide by zero.'
                    //If a string is entered: System.FormatException: 'Input string was not in a correct format.' 
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("This isn't algebra, enter a number.");   
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You cannot divide by zero because math. ");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nope.");
            }
            finally
            {
                Console.WriteLine("Math is fun.");
            }

            //Exception handling with Booleans and TryParse and while loop:
            bool validAnswer = false;
            int age = 0;
            try
            {
                while (!validAnswer)
                {
                    Console.WriteLine("What is your age?");
                    validAnswer = int.TryParse(Console.ReadLine(), out age);    //TryParse is a method that has required out parameters (input*, out variableName);  *input may be a Console.ReadLine(), or another variable
                    if (!validAnswer) Console.WriteLine("Please enter whole numbers only (no decimals).");
                    else validAnswer= true;
                }
                if (age < 0)
                {
                    throw new NumberException();
                }
                else
                {
                    //DateTime Syntax: DateTime variableName = new DateTime(year, mo, day, hour, min, second);
                    DateTime dt = DateTime.Now;
                    int currentYear = dt.Year;
                    Console.WriteLine("You were (probably) born in: " + (currentYear - age));
                }
            }
            catch (NumberException) //Best practice is to be as specific as possible with exceptions. And to start with the most specific, before the generic "Exception".
            {
                Console.WriteLine("You did not enter a valid age.\nGoodbye");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("An error occured. Please contact your system administrator.\nGoodbye");
                Console.ReadLine();
                return;  //when you type return in a void method, it ends the method.
            }
        }
    }
}
