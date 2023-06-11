using System;

namespace Input_Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Check that user input is a number:
            Console.WriteLine("Please enter a number.");
            do
            {
                string userInput = Console.ReadLine();
                int number;

                //Syntax: int.TryParse(variable to attempt to convert to an int, int variable to store the number if the call succeeds).
                if (!int.TryParse(userInput,out number))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You did not enter a valid input.");
                    Console.ResetColor();
                    Console.WriteLine("Please enter a number.");
                }
                else
                {
                    Console.WriteLine("Thank you. Please enter another number.");
                }

            } while (true);
        }
    }
}