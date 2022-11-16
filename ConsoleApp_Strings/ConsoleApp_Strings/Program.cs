using System;
using System.Text;

namespace ConsoleApp_Strings
{
    class Strings
    {
        static void Main(string[] args)
        {
            //The backslash indicates a special character. \n is new line. \t is tab. \\ is one backslash.
            string quote = "Escape characters, like \"\\\", allow programmers \n\tto use \n\t\tspecial characters";
            Console.WriteLine(quote);
            //The @ symbol before a "string" indicates there are no escape characters
            string filename = @"C:\Users\jad245";
            Console.WriteLine(filename);

            //Concatenate strings:
            string string1 = "\nProgramming haiku. ";
            string string2 = "With so many things to learn. ";
            string string3 = "Remember to blink.\n";
            Console.WriteLine(string1 + string2 + string3);

            //String methods:
            string name = "Jesse";
            bool trueOrfalse = name.Contains("s");
            Console.WriteLine(trueOrfalse);
            Console.WriteLine(name.EndsWith("s"));
            Console.WriteLine(name.Length);
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());

            //From Microsoft's .NET(C#) docs, format strings: 
            var pw = (firstName: "Phillis", lastName: "Wheatley", born: 1753, published: 1773);
            Console.WriteLine("\n{0} {1} was an African American poet born in {2}.", pw.firstName, pw.lastName, pw.born);
            Console.WriteLine("She was first published in {0} at the age of {1}.", pw.published, pw.published - pw.born);
            Console.WriteLine("She'd be over {0} years old today.", Math.Round(2018d - pw.born));
            // Output:
            // Phillis Wheatley was an African American poet born in 1753.
            // She was first published in 1773 at the age of 20.
            // She'd be over 300 years old today.

            //String Builder: a class for changing strings.
            StringBuilder sb = new StringBuilder();
            sb.Append("\nParagraph #1. ");
            sb.Append("Paragraph #2. ");
            sb.Append("Paragraph #3. ");
            Console.WriteLine(sb);
        }
    }
}