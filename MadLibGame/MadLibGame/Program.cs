using System;
using System.Text;   //required from StringBuilder
using System.Collections.Generic; //required for Lists

namespace MadLibGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(".............A DAY AT THE BEACH...............");
            Console.WriteLine(@"            .   :  ;   ,          ___       ");
            Console.WriteLine(@"""------.__  \.      ,/    .----'''  ''`--. ");
            Console.WriteLine(@"____.------'-   ,--.  -    ""-------'""""   ");
            Console.WriteLine(@"\_______ - _ -= ___ / ____\__ = -_ - _______");
            Console.WriteLine(@"`\.              --           .--'   \' -.  ");
            Console.WriteLine(@". `\._          ""--'         ""'\'' / ''   ");
            Console.WriteLine(@" `    `'--..     --                ''       ");
            Console.WriteLine(@"     --',.---' -  '                         ");
            Console.WriteLine(@"----'""'                               ''   ");
            Console.WriteLine(@"  / ____,,....__                            ");
            Console.WriteLine("It's a tranquil day at the beach...what could possibly happen?\n");

            //Create a list of madLibs strings from the user's input:
            List<string> madLibs = new List<string>();
            Console.WriteLine("Enter an adjective:");
            string madLib0 = Console.ReadLine();
            madLibs.Add(madLib0);
            Console.WriteLine("Enter a noun:");
            string madLib1 = Console.ReadLine();
            madLibs.Add(madLib1);
            Console.WriteLine("Enter another noun:");
            string madLib2 = Console.ReadLine();
            madLibs.Add(madLib2);
            Console.WriteLine("Enter another adjective:");
            string madLib3 = Console.ReadLine();
            madLibs.Add(madLib3);
            Console.WriteLine("Enter a verb:");
            string madLib4 = Console.ReadLine();
            madLibs.Add(madLib4);
            Console.WriteLine("Enter another adjective:");
            string madLib5 = Console.ReadLine();
            madLibs.Add(madLib5);
            Console.WriteLine("Enter another verb:");
            string madLib6 = Console.ReadLine();
            madLibs.Add(madLib6);
            Console.WriteLine("Enter your name or alias:");
            string madLib7 = Console.ReadLine();
            madLibs.Add(madLib7);

            //Define the strings that will be used for the madLib game: 
            string[] storyArray = { "Dear Diary, today is going to be ", ". I am a biologist aboard the USS ", ". I study the elusive sea ", ". One afternoon, on my day off, I decided to visit the nearby ", " Beach. While ", "-ing alone, I found a tidepool full of unknown ", " creatures. They ", "-ed all over me! But I finally managed to capture a specimine. \nThis discovery will forever etch my name into the halls of science! \nRemember the name of Dr. " };

            //Iterate through the storyArray, add each madLib string to the end of each storyArray string:
            for (int i = 0; i<storyArray.Length; i++)
            {
                storyArray[i] = storyArray[i] + madLibs[i].ToUpper();
            }

            //Iterate through the amended storyArray and print each 'sentence':
            foreach (string sentence in storyArray)
            {
                Console.Write(sentence);
            }

            Console.WriteLine("\nBonus: Did the encounter kill you off by a previously unknown poison?\nPick a number to decide your fate:");
            int roulette = Convert.ToInt32(Console.ReadLine());
            //Infinte loop: (Instead of a (infinite) while statement, use an ternary statement)
            //bool alive = true;
            //while (alive)
            //{
            //    Console.WriteLine("Luckily for you, it turns out it was just a sunburn, not poinson.");
            //}
            string alive = roulette % 2 == 0 ? "Luckily for you, it turns out it was just a sunburn, not poinson." : "Tragically, you succumb to the poison.\nBut a statue is erected at the beach in honor of your scientific discoveries.";  //result if true : result if false
            Console.WriteLine(alive);

            //3
            //Use <= operator to iterate through a list:
            List<string> creatureLetters = new List<string>() { "A", "B", "D", "G", "I", "K", "N", "O", "W", "V"};
            for (int i = 0; i<=9; i++)
            {
                Console.WriteLine(creatureLetters[i]);
            }

            //4
            //Get user input text to search for in a list:
            Console.WriteLine("Now you must NAME your discovery. Enter a letter from the list above.");
            string creatureLetter = Console.ReadLine();
            //iterates through a list and displays the index of the list item that contains matching text:
            List<string> creatureAdjs = new List<string>() {"Abashed", "Kerfuffled", "Barbarous", "Debonair", "Garrulous", "Incandescent","Onerous","Waggish", "Voracious", "Nebulous" };
            bool validLetter = false;
            foreach (string adj in creatureAdjs)
            {
                if (adj.StartsWith(creatureLetter.ToUpper()))
                {
                    //Get the index number of the matching result:
                    Console.WriteLine(creatureAdjs.IndexOf(adj));
                    Console.WriteLine("The name of your creature is: The " + adj + " " + madLib7);
                    validLetter = true;
                }
            }
            //If a letter that doesn't meet the foreach loop criteria is entered, and the validLetter 'trigger' remains false, print this statement: 
            if (validLetter == false)
            {
                Console.WriteLine("Your input was not on the list.");
            }

            //5
            List<string> creatureColors = new List<string>() { "pink", "red", "red", "orange", "yellow", "green", "blue", "purple", "brown", "black", "white" };
            Console.WriteLine("Record the color of your discovery. Pick a common color:");
            string creatureColor = Console.ReadLine();
            //Create a boolean 'trigger':
            bool validColor = false;
            //Iterate through the creatureColors list to find matches by using an if statement:
            for (int i = 0; i < creatureColors.Count ; i++)
            {
                if (creatureColor.ToLower() == creatureColors[i])
                {
                    validColor = true; //Change the boolean 'trigger' if true.
                    //Use a switch statement to provide results based on user input:
                    switch (creatureColor.ToLower())
                    {
                        case "pink":
                            Console.WriteLine("You record the color as pink!");
                            Console.WriteLine("The index number for this record is: " + i);
                            break; 
                        case "red":
                            Console.WriteLine("You record the color as red!");
                            Console.WriteLine("The index number for this record is: " + i);
                            break; 
                        case "orange":
                            Console.WriteLine("You record the color as orange!");
                            Console.WriteLine("The index number for this record is: " + i);
                            break; 
                        case "yellow":
                            Console.WriteLine("You record the color as yellow!");
                            Console.WriteLine("The index number for this record is: " + i);
                            break; 
                        case "green":
                            Console.WriteLine("You record the color as green!");
                            Console.WriteLine("The index number for this record is: " + i);
                            break; 
                        case "blue":
                            Console.WriteLine("You record the color as blue!");
                            Console.WriteLine("The index number for this record is: " + i);
                            break; 
                        case "purple":
                            Console.WriteLine("You record the color as purple!");
                            Console.WriteLine("The index number for this record is: " + i);
                            break; 
                        case "brown":
                            Console.WriteLine("You record the color as brown!");
                            Console.WriteLine("The index number for this record is: " + i);
                            break; 
                        case "white":
                            Console.WriteLine("You record the color as white!");
                            Console.WriteLine("The index number for this record is: " + i);
                            break; 
                        case "black":
                            Console.WriteLine("You record the color as black!");
                            Console.WriteLine("The index number for this record is: " + i);
                            break;
                    }
                }
            }
            if (validColor == false)
            {
                Console.WriteLine("You entered a color unknown to science.");
            }

            //6
            //Check a list for identical strings:
            List<string> checkForContains = new List<string>();
            foreach (string color in creatureColors)
            {
                //Use a boolean 'trigger' with the .Contains method to indicate if a value is already in the list:
                bool duplicate = checkForContains.Contains(color);
                //After checking the list, add this color to it:
                checkForContains.Add(color);
                //The if statement proceeds according to the boolean 'trigger': 
                if (duplicate == false)
                {
                    Console.WriteLine(color + " is a unique value.");
                }
                else
                {
                    Console.WriteLine(color + " is a duplicate and already appeared on the list");
                }
            }
            Console.ReadLine();
        }
    }
}
