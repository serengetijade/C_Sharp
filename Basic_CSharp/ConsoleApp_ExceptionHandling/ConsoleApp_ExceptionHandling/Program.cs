using System;
using System.Collections.Generic; //required for Lists


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
                Console.WriteLine("Pleas enter a number");
                decimal divisor = Convert.ToDecimal(Console.ReadLine());
                for (int i = 0; i < numbers.Count; i ++)
                {
                    Console.WriteLine(i / divisor);
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
                Console.ReadLine();
            }

        }
    }
}
