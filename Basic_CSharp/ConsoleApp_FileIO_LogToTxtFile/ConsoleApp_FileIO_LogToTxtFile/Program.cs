using System;
using System.IO;    //Contains methods needed for working with files. 
using System.Text;  //Methods for UTF8Encoding.

namespace ConsoleApp_FileIO_LogToTxtFile
{
    class Program
    {
        static void Main(string[] args)
        {

            //CREATE A NEW FILE:
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

            ////STREAMWRITER: Append a string to a file using StreamWriter:
            //Console.WriteLine("Please enter a line to append to the file:");
            //string answer1 = Console.ReadLine();
            //Console.WriteLine($"You entered: \"{answer1}\"");
            ////StreamWriter: write user input to a (.txt) file:`
            ////Syntax: using (StreamWriter file = new StreamWriter(@"C:\path\path\fileName.txt", true))
            //using (StreamWriter file = new StreamWriter($"C:\\Users\\jad24\\Documents\\CodingProjects\\ActiveProjects\\{filename}.txt", true))
            //{
            //    //file.WriteLine(answer);
            //    file.WriteLine(DateTime.Now.ToString("\nMM/dd/yyyy h:mm:ss tt") + ": " + answer1);     //Automatically writes to a new line. 
            //}

            ////FILESTREAM: Append text to a file using FileStream:
            //Console.WriteLine("Please enter another line to append to the file:");
            //string answer2 = DateTime.Now.ToString("MM/dd/yyyy h:mm:ss tt") + ": " + Console.ReadLine();
            ////Note: FileStream adds via a byte array, so strings must be converted to byte arrays:
            //byte[] infoToAdd = new UTF8Encoding(true).GetBytes(answer2);
            ////New FileStream Syntax: FileStream varName = File.Open(path, FileMode.methodName); 
            //FileStream fs = File.Open(path, FileMode.Append);
            ////Syntax: FileStreamInstanceName.Write(byteArray varName, offset, limit for lenght of the text to write to the file);   
            //fs.Write(infoToAdd, 0, infoToAdd.Length);
            //fs.Close();

            //STREAMREADER: Read data from a file and get it into C# code:
            StreamReader sr = new StreamReader(path);
            string fileText1 = sr.ReadToEnd();
            Console.WriteLine(fileText1);

            Console.ReadLine();
        }
    }
}
