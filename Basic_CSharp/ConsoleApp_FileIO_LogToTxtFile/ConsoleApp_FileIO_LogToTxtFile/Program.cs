using System;
using System.IO; //Contains methods needed for working with files. 

namespace ConsoleApp_FileIO_LogToTxtFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter a line to append to the file:");
            //string answer = Console.ReadLine();
            //Console.WriteLine($"You entered: \"{answer}\"");

            ////StreamWriter: write user input to a (.txt) file:`
            //using (StreamWriter file = new StreamWriter(@"C:\Users\jad24\Documents\CodingProjects\ActiveProjects\log.txt", true))
            //{
            //    //file.WriteLine(answer);
            //    file.WriteLine(DateTime.Now.ToString("MM/dd/yyyy h:mm:ss tt") + ": " + answer);     //Automatically writes to a new line. 
            //}
            //Console.ReadLine();         ;

            //Create a new file:
            Console.WriteLine("Enter a file name:");
            string filename = Console.ReadLine();
            //Note: in the string path, use double \\ to avoid escape character mixup
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + $"\\CodingProjects\\ActiveProjects\\{filename}.txt";
            //Check if file exists so as to NOT overwrite it:
            if (!File.Exists(path))
            {
                File.Create(path);
                Console.WriteLine("A new file was created."); 
            }
            else
            {
                Console.WriteLine("That filename already exists.");
            }

        }
    }
}
