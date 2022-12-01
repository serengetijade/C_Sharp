using System;
using System.IO;

namespace ConsoleApp_FileIO_LogToTxtFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            string answer = Console.ReadLine();
            Console.WriteLine($"You entered {answer}");
            //Write each card delt to a txt file:`
            using (StreamWriter file = new StreamWriter(@"C:\Users\jad24\Documents\Coding Projects\C_Sharp\TwentyOneGame\TwentyOneGame\log.txt", true))
            {
                file.WriteLine(answer);
            }
            Console.ReadLine();
        }
    }
}
