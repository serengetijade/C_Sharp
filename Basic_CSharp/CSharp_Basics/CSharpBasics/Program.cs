using System;
using System.Text;   //required from StringBuilder
using System.Collections.Generic; //required for Lists

/*namespace CSharpBasics
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Acme Accounting Systems\nRemember, we're \"accounting\" on you!");
            Console.Read();
        }
    }
}*/

/*namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ctrl + k + c = comments out all selected lines. Ctrl + k + u = uncomments selected lines. 
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourName);
            //Console.Read();

            //Data types:
            //bool isStudying = true;
            //byte hourseWorked = 42;
            //sbyte currentTemperature = -23;
            //char questionMark = '\u2103';
            //double heightINcm = 69.234;
            //decimal moneyInBank = 100.5m;
            //float secondsLeft = 2.62f;
            //short tempMars = -341;

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int favNumber = Convert.ToInt32(favoriteNumber);
            //int total = favNumber + 5;
            //Console.WriteLine("Your favorite number, plus 5, is: " + total);

            //int currentAge = 30;
            //string yearsOld = currentAge.ToString();
            //bool isRaining = true;
            //string rainingStatus = Convert.ToString(isRaining);

        }
    }
}*/

/*namespace DailyReportApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy\nStudent Daily Report");

            Console.WriteLine("What is your name?");        //Write a question to the console.
            string studentName = Console.ReadLine();        //Accept user input and store it as a (string type) variable.
            Console.WriteLine("What course are you on?");
            string studentCourse = Console.ReadLine();
            Console.WriteLine("What page number?");
            string page = Console.ReadLine();
            short pageNumber = Convert.ToInt16(page);       //convert user input to short data type
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string help = Console.ReadLine();
            bool helpWith = Convert.ToBoolean(help);
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveExp = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string study = Console.ReadLine();
            decimal studyHours = Convert.ToDecimal(study);  //convert user input to decimal data type. 

            Console.WriteLine("Thank you for your answers.\nAn Instructor will respont to this shortly.\nHave a great day!");
            Console.Read();
        }
    }
}*/

/*namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {   
            int num1 = 5;
            int num2 = 7;
            int diff = num1 - num2;
            Console.WriteLine(diff);

            int product = num1 * num2;
            Console.WriteLine(product);

            int remainder = num2 % num1;
            Console.WriteLine(remainder);

            int num3 = 8;
            float num4 = 5.5f;
            float total1 = num3 + num4;
            int total2 = num3 + (Int32)num4;
            Console.WriteLine(total1 + " & " + total2);

            //String concatenation: 
            string myName = "Jade";
            string username = myName + num4;
            Console.WriteLine(username);

            Console.WriteLine("Please enter a number:");
            string userNum = Console.ReadLine();
            float userNumber = Convert.ToSingle(userNum);
            Console.WriteLine("Times 50: "+ userNumber * 50);
            Console.WriteLine("Plus 25: " + userNumber + 25);
            Console.WriteLine("Divided by 12.5: " + userNumber / 12.5);
            Console.WriteLine("Is greater than 50? " + (userNumber > 50));
            Console.WriteLine("Remainder from 7: " + (userNumber % 7));     //Use the modulus to find the remainder after userNumber/7

            Console.WriteLine("Anonymous Income Comparison Program\nPlease enter Person 1's information.\n1-Hourly Rate: ");
            decimal rate1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("1-Hours worked per week: ");
            decimal hours1 = Convert.ToDecimal(Console.ReadLine());                
            Console.WriteLine("Please enter Person 2's information.\n2-Hourly Rate: ");
            decimal rate2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("2-Hours worked per week: ");
            decimal hours2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Annual Salary of Person 1: $" + (rate1*hours1*52));
            Console.WriteLine("Annual Salary of Person 2: $" + (rate2*hours2*52));
            Console.WriteLine("Does Person 1 make more than Person 2?: \n" + ((rate1 * hours1 * 52) > (rate2 * hours2 * 52)));
            
            int packWidth = 10;
            int packHeight = 25;
            //bool tooBig = (packWidth > 25 && packHeight > 25);    //AND operator
            bool tooBig = (packWidth > 25 || packHeight > 25);      //OR operator
            Console.WriteLine(tooBig);

            string firstname = "Jesse";
            string lastname = "Johnson";
            string ssn = "111-11-1111";
            //Combine multiple comparison operators with Boolean logic:
            bool isAuthorized = (firstname == "Jesse" && lastname == "Johnson" && ssn == "111-11-1111");
            Console.WriteLine(isAuthorized);
            bool result = (7 > 12 && (3 == 4 || 8 > 5));
            Console.WriteLine(result);
            Console.Read();
           

            Console.WriteLine(true && false);    //Result: False
            Console.WriteLine(true && true);     //Result: True
            Console.WriteLine(false && false);   //Result: False

            Console.WriteLine(true || true);     //Result: True
            Console.WriteLine(true || false);    //Result: True
            Console.WriteLine(false || false);   //Result: False

            Console.WriteLine(true == true);     //Result: True
            Console.WriteLine(true == false);    //Result: False
            Console.WriteLine(false == false);   //Result: True

            Console.WriteLine(true != true);     //Result: False
            Console.WriteLine(true != false);    //Result: True
            Console.WriteLine(false != false);   //Result: False

            Console.WriteLine(true ^ true);      //Result: False   xor operator: Evaluate to true if one statement is true BUT NOT BOTH
            Console.WriteLine(true ^ false);     //Result: True    xor operator: Evaluate to true if one statement is true BUT NOT BOTH
            Console.WriteLine(false ^ false);    //Result: False   xor operator: Evaluate to true if one statement is true BUT NOT BOTH
            Console.ReadLine();
        }
    }
}*/

/*namespace InsuranceApprovalApp
{
    class InsApproval
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? Enter y or n");
            char DUI = Convert.ToChar(Console.ReadLine());
            bool hasDUI = false;
            //Use the .Equals method and comparison operators in an if statement:
            if (Char.Equals(DUI, 'y') || Char.Equals(DUI, 'Y')) 
            {
                hasDUI = true;
            }
            else
            {
                hasDUI = false;
            }
            Console.WriteLine("How many speeding tickets do you have");
            int speeding = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qualified? " + (age >= 18 && hasDUI == false && speeding <= 3));    //Use AND to compare boolean results
            Console.ReadLine();
        }
    }
}*/

/*namespace ifStatements
{
    class ifStatements
    {
        static void Main(string[] args)
        {   
            if(true)
            {
                Console.WriteLine("Hello!");
            }

            if (1 == 1) //Use an equality comparison operator. 
            {
                Console.WriteLine("1 equals 1!");
            }
            else
            {
                Console.WriteLine("1 does not equal 1");
            }

            string name = "Adam";
            if (name == "Jesse")
            {
                Console.WriteLine("Your name is Jesse");
            }
            else if (name == "Brett")
            {
                Console.WriteLine("Your name is Brett, not Jesse");
            }
            else
            {
                Console.WriteLine("Your name is not Jesse nor Brett");
            }

            if (1 != 2)
            {
                Console.WriteLine("All is right with the universe.");
            }
            else
            {
                Console.WriteLine("We live in a bizarro world.");
            }

            int age = 19;
            if (age <= 17)
            {
                Console.WriteLine("You are too young for the movie.");
            }
            else
            {
                Console.WriteLine("Enjoy the show!");
            }

            string role = "admin";
            if (role == "admin" || role == "administration")
            {
                Console.WriteLine("You may access the entire softwrae system.");
            }

            //Ternary (?) operator
            int num1 = 7;
            int num2 = 12;
            string result = num1 > num2 ? "num1 is greater than num2" : "num1 is not greater than num2";  //result if true : result if false
            Console.WriteLine(result);
            

            int currentTemp = 80;
            int roomTemp = 70;
            if (currentTemp == roomTemp)
            {
                Console.WriteLine("It is exactly room temperture.");
            }
            else if(currentTemp > roomTemp)
            {
                Console.WriteLine("It is warmer than room temperture.");
            }
            else
            {
                Console.WriteLine("It is not exactly room temperature.");
            } 
            

            //To write the above with ternary (?) operator:
            int currentTemp = 80;
            int roomTemp = 70;
            string comparisonResult = currentTemp == roomTemp ? "It is room temperature" : "It is not room temperature";
            Console.WriteLine(comparisonResult);

            Console.WriteLine("What is your favorite number?");
            int favNum = Convert.ToInt32(Console.ReadLine());
            string result = favNum == 12 ? "You have an awesome favorite number!" : "That is an interesting choice.";
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}*/

/*namespace ShippingQuoteApp
{
    class ShippingQuote
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express.\nPlease follow the instructions below.\nWhat is the package weight?");
            decimal packWeight = Convert.ToDecimal(Console.ReadLine());
            if (packWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }
            else
            {
                //Console.ReadLine() to get the user's package dimensions:
                Console.WriteLine("What is the package width?");
                decimal packWidth = Convert.ToDecimal(Console.ReadLine());                  
                Console.WriteLine("What is the package height?");
                decimal packHeight = Convert.ToDecimal(Console.ReadLine());                  
                Console.WriteLine("What is the package length?");
                decimal packLength = Convert.ToDecimal(Console.ReadLine());
                //Ternary operator (?) to return if (not) shipable or a shipping quote:
                string ship = (packWidth + packHeight + packLength) > 50 ? "Package too big to be shipped via Package Express." : "Shipping quote: $" + ((packWidth * packHeight * packLength * packWeight) / 100);
                Console.WriteLine(quote);
            }                        
        }
    }
}*/

/*namespace Switch
{
    class Switch
    {
        static void Main(string[] args)
        {
            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;                 
                case 2:
                    Console.WriteLine("Tuesday");
                    break;                    
                case 3:
                    Console.WriteLine("Wednesday");
                    break;                     
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                default:
                    Console.WriteLine("Default is optional and specifies some code to run if there is no case match.");
                    break;
            }

            //Switch with While loop:
            Console.WriteLine("Guess a number...");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 42;  
            //Note that if the first guess is 42, the while loop is NOT triggered: 
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
            //The solution is to use a 'do' with a while loop:
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
        }
    }
}*/

/*namespace Strings
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

            //String methods:
            string name = "Jesse";
            bool trueOrfalse = name.Contains("s");
            Console.WriteLine(trueOrfalse);
            trueOrfalse = name.EndsWith("s");
            Console.WriteLine(trueOrfalse);
            Console.WriteLine(name.Length);
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());

            var pw = (firstName: "Phillis", lastName: "Wheatley", born: 1753, published: 1773);
            Console.WriteLine("{0} {1} was an African American poet born in {2}.", pw.firstName, pw.lastName, pw.born);
            Console.WriteLine("She was first published in {0} at the age of {1}.", pw.published, pw.published - pw.born);
            Console.WriteLine("She'd be over {0} years old today.", Math.Round(2018d - pw.born));
            // Output:
            // Phillis Wheatley was an African American poet born in 1753.
            // She was first published in 1773 at the age of 20.
            // She'd be over 300 years old today.

            StringBuilder sb = new StringBuilder();
            sb.Append("My name is Jessee");
            Console.WriteLine(sb);
        }
    }
}*/
/*namespace ArraysAndLists
{
    class ArraysAndLists
    {
        static void Main()
        {
            //Required: using System.Collections.Generic; //required for Lists
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
            int[] numberArray3 = { 5, 2, 10, 200, 5000, 600, 2300};
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

            //Read an array using user input to determin the index number:
            string[] stringArray = {"dragon", "cat", "dog", "cow", "tiger", "turtle", "pig", "wolf", "toad", "dolphin", "hedgehog" };
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
            Console.WriteLine("You have " + intArray[indexNumber] + " people who think you're neat.");

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
            Console.WriteLine("Your aura is " + stringList[indexNumber] + "-colored.");

            Console.ReadLine();
        }
    }
}*/

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

            //LIST ITERATION
            List<int> testScores = new List<int>();
            testScores.Add(98);
            testScores.Add(99);
            testScores.Add(81);
            testScores.Add(72);
            testScores.Add(70);

            foreach(int t in testScores)
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
            List<int> testResults = new List<int>() { 98,99,12,74,23,94};
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

            //Check a list for identical strings:
            List<string> colors = new List<string>() { "pink", "red", "red", "orange", "yellow", "green", "blue", "purple", "brown", "black", "white" };
            List<string> checkForContains = new List<string>();
            foreach (string color in colors)
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
}  */
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
        }
    }
}*/