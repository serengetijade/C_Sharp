using System;
using System.Collections.Generic;
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

            //Reverse a string - Array.Reverse
            string reverseMe1 = "Reverse this string!";
            char[] characterArray1 = reverseMe1.ToCharArray();
            Array.Reverse(characterArray1);
            string reverseString1 = new string(characterArray1);
            Console.WriteLine($"The string is: {reverseMe1}");
            Console.WriteLine($"Backwards it reads: {reverseString1}");

            //Reverse a string - WHILE loop
            string reverseMe2 = "Reverse another string!";
            string reverseString2 = ""; 
            int length = reverseMe2.Length - 1;
            while (length > 0)
            {
                reverseString2 = reverseString2 + reverseMe2[length];
                length--;
            }
            Console.WriteLine(reverseMe2);
            Console.WriteLine($"Backwards it reads: {reverseString2}");

            //Reverse a string - FOR loop
            string reverseMe3 = "Reverse a third string!";
            char[] stringArray = reverseMe3.ToCharArray();
            string reverseString3 = String.Empty;
            for (int i = stringArray.Length -1; i >= 0; i--)
            {
                reverseString3 += stringArray[i];
            }
            Console.WriteLine(reverseMe3);
            Console.WriteLine($"Backwards it reads: {reverseString3}");

            //Remove repeated/duplicate letters from a string:
            string string4 = "This is the string that needs all duplicates removed";
            var string4HS = new HashSet<char>(string4);
            StringBuilder withoutRepeats = new StringBuilder();
            foreach (char c in string4HS)
            {
                withoutRepeats.Append(c);
            }
            Console.WriteLine($"This is the string that needs all duplicates removed: {withoutRepeats.ToString()}");
        }
    }
}
/*namespace Iteration
{
    class Iteration
    {
        static void Main(string[] args)    //args lets you pass in information as an argument to this function. For ex, from the command line. 
        {
            
            //Required: using System.Collections.Generic; //required for Lists
            //ARRAY ITERATION
            int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };
            for (int i = 0; i < testScores.Length; i++)
            {
                if (testScores[i] > 85)
                {
                    Console.WriteLine("Passing test score: " + testScores[i]);
                }
            }

            string[] names = { "Jesse", "Erik", "Daniel", "Adam" };
            for (int j = 0; j < names.Length; j++)
            {
                //Write every object to the console: 
                Console.WriteLine(names[j]); 
                //Perform an if function: 
                if (names[j] == "Jesse")
                {
                    Console.WriteLine(names[j]);
                }
            }
            Console.ReadLine();             

            //LIST ITERATION
            List<int> testScores = new List<int>();
            testScores.Add(98);
            testScores.Add(99);
            testScores.Add(81);
            testScores.Add(72);
            testScores.Add(70);

            foreach (int t in testScores)
            {
                if (t > 85)
                {
                    Console.WriteLine("Passing test score: " + t);
                }
            }

            //Popular naming convention is to use plural for the name of a list, then the singular for the iteration variable. 
            List<string> names = new List<string>() { "Jesse", "Erik", "Adam", "Daniel" };
            foreach (string name in names)
            {
                //Print all names to the console:
                Console.WriteLine(name);
                //If statement: 
                if (name == "Jesse")
                {
                    Console.WriteLine(name);
                }
            }

            //Add values from one list that meet a condition to another list: 
            List<int> testResults = new List<int>() { 98, 99, 12, 74, 23, 94 };
            List<int> passingResults = new List<int>();
            //Use a for loop and an if statement to find values that meet set condition:
            foreach (int result in testResults)
            {
                if (result > 85)
                {
                    //listName.Add method:
                    passingResults.Add(result);
                }
            }
            Console.Write("Number of passing results: " + passingResults.Count);
            Console.ReadLine();

        }
    }
}*/