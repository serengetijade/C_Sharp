using System;

/*
namespace CSharpBasics
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

/*
namespace VariablesAndDataTypes
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

/*
namespace DailyReport
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
/*
namespace Operators
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
/*
namespace InsuranceApproval
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
namespace ifStatements
{
    class ifStatements
    {
        static void Main(string[] args)
        {   /*
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
            */

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
}