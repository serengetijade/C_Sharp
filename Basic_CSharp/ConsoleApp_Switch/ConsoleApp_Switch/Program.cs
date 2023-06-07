using System;

namespace Switch
{
    class Switch
    {
        static void Main(string[] args)
        {
            //Switch with While loop:
            Console.WriteLine("Guess a number...");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 42;

            //Note that if the first guess is 42(the correct answer), the while loop is NOT triggered: 
            //while (!isGuessed)
            //{
            //    switch (number)
            //    {
            //        case 42:
            //            Console.WriteLine("You found the answer to everything!");
            //            isGuessed = true;
            //            break;
            //        default:
            //            Console.WriteLine("You guessed " + number + ". That is not correct.\nGuess again...");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //    }
            //}

            //The solution is to use a 'do' with a while loop, called a 'do while' loop:
            do
            {
                switch (number)
                {
                    case 42:
                        Console.WriteLine("You found the answer to everything!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You guessed " + number + ". That is not correct.\nGuess again...");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed);

            //Once the do while loop is completed, the rest of the code runs. 
            Console.WriteLine("This is the rest of the code: \nEnter a number between 1 and 3.");
            
            //Basic Switch Statement:
            int input1 = Convert.ToInt32(Console.ReadLine());
            switch (input1)
            {
                case 1:
                    Console.WriteLine("You entered the number {0}.", input1);
                    break;  
                case 2:
                    Console.WriteLine("You entered the number {0}.", input1);
                    break;  
                case 3:
                    Console.WriteLine("You entered the number {0}.", input1);
                    break;  
                default:
                    Console.WriteLine("That is not a number within the specified range.");
                    break;
            }

            Console.ReadLine();
        }
    }
}
