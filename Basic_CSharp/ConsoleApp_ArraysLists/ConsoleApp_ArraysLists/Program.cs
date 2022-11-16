using System;
using System.Collections.Generic; //required for Lists

namespace ConsoleApp_ArraysLists
{
    class ArraysAndLists
    {
        static void Main()
        {
            /*
            //Instantiate an Array:
            int[] numberArray1 = new int[5];
            //Add objects to the array by referencing their index numbers:
            //Index numbers in C# start counting from zero. 
            numberArray1[0] = 5;
            numberArray1[1] = 2;
            numberArray1[2] = 10;
            numberArray1[3] = 200;
            numberArray1[4] = 5000;
            Console.WriteLine(numberArray1[3]);

            //Instantiate an array by defining a new type and array, using a set (defined by {curly brackets}):
            int[] numberArray2 = new int[] { 5, 2, 10, 200, 5000 };
            Console.WriteLine(numberArray2[3]);

            //Instantiate an array using only a set:
            int[] numberArray3 = { 5, 2, 10, 200, 5000, 600, 2300 };
            Console.WriteLine(numberArray3[3]);
            //Change an object
            numberArray3[5] = 650;
            Console.WriteLine(numberArray3[5]);

            //(byte) arrays are useful for storing a lot of information
            //byte[] byteArray = new byte[5000];        

            //Instantiate a list
            List<int> intList = new List<int>();
            intList.Add(4);
            intList.Add(10);
            intList.Remove(10);
            Console.WriteLine(intList[0]);
            */

            //Read an array using user input to determin the index number:
            string[] stringArray = { "dragon", "cat", "dog", "cow", "tiger", "turtle", "pig", "wolf", "toad", "dolphin", "hedgehog" };
            Console.WriteLine("What is your spirit animal?\nChoose a whole number up to 10.");
            int indexNumber = Convert.ToInt32(Console.ReadLine());
            //If statement for user selection: 
            if (indexNumber <= 10 && indexNumber >= 0)
            {
                Console.WriteLine("Your spirit animal is a " + stringArray[indexNumber] + ".");
            }
            else
            {
                Console.WriteLine("You didn't pick a valid number. You will have to live in ignorance.");
            }

            int[] intArray = { 100, 45, 30, 56, 62, 77, 17, 28, 81, 49, 68 };
            Console.WriteLine("How popular are you?\nChoose a whole number up to 10.");
            indexNumber = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine("You have " + intArray[indexNumber] + " people who think you're neat.");
            }
            catch
            {
                Console.WriteLine("You didn't pick a valid number.");
            }

            List<string> stringList = new List<string>();
            stringList.Add("Vermilion");
            stringList.Add("Puce");
            stringList.Add("Chartreuse");
            stringList.Add("Smalt");
            stringList.Add("Zaffre");
            stringList.Add("Aureolin");
            stringList.Add("Titian");
            stringList.Add("Alabaster");
            stringList.Add("Wenge");
            stringList.Add("Celadon");
            stringList.Add("Cerulean");
            Console.WriteLine("What color is your aura? Enter a whole number up to 10 to find out.");
            indexNumber = Convert.ToInt32(Console.ReadLine());
            if (indexNumber <= 10 && indexNumber >= 0)
            {
                Console.WriteLine("Your aura is " + stringList[indexNumber] + "-colored.");
            }
            else
            {
                Console.WriteLine("You didn't pick a valid number. You have no aura to read.");
            }
            Console.ReadLine();
        }
    }
}

